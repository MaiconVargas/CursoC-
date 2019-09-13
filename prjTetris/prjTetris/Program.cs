using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

// email:   strikerblade@rocketmail.com
// website: http://strikerblade.somee.com

namespace prjTetris
{
    class Program
    {        
        const int    MAX_SPEED     = 9;
        const double DEFAULT_SPEED = 0.9; // 0.9 seconds

        const string msg1 = "   Fim de Jogo!!!   ";
        const string msg2 = " Pressione algo para sair. ";
        const string msg3 = " P A R A B É N S !!! ";
        const string msg5 = "PRESSIONE ALGO PARA INICIAR.";
        const string msg6 = "PRESSIONE ALGO PARA CONTINUAR.";

        static int Speed = 1; // Speed of the game.
        static int Score = 0; // Total score.
        static int Lines = 0; // Total lines completed.

        static Point ptBlock         = new Point();      // The x and y positions of the block.
        static WindowRect wrBlockAdj = new WindowRect(); // Block adjustment.
        static WindowRect PlayWindow = new WindowRect(); // The size of the field.    
        static Sound sndEffect       = new Sound();      // Sound effect.
        static bool isRows           = false;            // Is full row?
        static bool isGameExit       = false;            // Terminate the game.

        static Game.StructBlock nextBlock = new Game.StructBlock();
        static Game.StructBlock currBlock = new Game.StructBlock();

        static ConsoleKeyInfo   kb;     // keyboard input
        static Game.TetrisClass Tetris;
        
        static void Main(string[] args)
        {   
            // Much better to use than GetTickCount because it's more precise.
            Stopwatch stopWatch = new Stopwatch();
            
            GameDesign();
            
            Tetris = new Game.TetrisClass(PlayWindow);
            // Hook up the ProcessEvent.
            Tetris.ProcessEvent += new Game.TetrisHandler(Tetris_Process);
            
            ShowStatus();
            // Set up the next block
            ShowNextBlock();
            // Set up the first block
            PlayBlock(currBlock, true);

            // Start the game.
            stopWatch.Start();
            while (!isGameExit) // continue looping until escape key has been pressed.
            {
                TimeSpan ts      = stopWatch.Elapsed; 
                Point newPos     = ptBlock;           // Temporary variable for new position.
                bool isCanRotate = false;

                if(Console.KeyAvailable)
                {
                    // get key input
                    kb = Console.ReadKey(true); 
                    
                    switch(kb.Key)
                    {
                        case ConsoleKey.Enter: // pause, resume
                            // PRESS ANY KEY TO CONTINUE.
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition((Console.WindowWidth - msg6.Length) / 2,
                                                       PlayWindow.height+PlayWindow.top+2);
                            Console.Write(msg6);
                            Console.ResetColor();
                            Console.ReadKey();
                            // clear the message from the bottom window.
                            ClearBottomLine();
                            break;
                        case ConsoleKey.LeftArrow: // move left
                            // Could go left?
                            if(PlayWindow.left<newPos.x)
                                newPos.x--;
                            break;
                        case ConsoleKey.RightArrow: // move top
                            // Could go right?
                            if((PlayWindow.width+PlayWindow.left)>(newPos.x+wrBlockAdj.width))
                                newPos.x++; 
                            break;                    
                        case ConsoleKey.DownArrow: // move down 
                            // Could go down?
                            if((PlayWindow.height+PlayWindow.top)>(newPos.y+wrBlockAdj.height))
                                newPos.y++; 
                            break;
                        case ConsoleKey.UpArrow:  // rotate
                        case ConsoleKey.Spacebar: // rotate
                            WindowRect newBlockAdj = new WindowRect();
                            
                            // Save old angle.
                            Game.RotationEnum saveAngle = Tetris.Block.Angle;

                            // try clockwise
                            newBlockAdj = Tetris.Block.Rotate(Tetris.Block.getNextAngle(0));

                            if(newPos.x+newBlockAdj.width>PlayWindow.width+PlayWindow.left)
                                newPos.x = (PlayWindow.width+PlayWindow.left) - newBlockAdj.width;
                            if(newPos.y+newBlockAdj.height>PlayWindow.height+PlayWindow.top)
                                newPos.y = (PlayWindow.height+PlayWindow.top) - newBlockAdj.height;

                            if(Tetris.IsCollided(new Point(newPos.x, newPos.y), newBlockAdj))
                            {
                                // try counter-clockwise
                                newBlockAdj = Tetris.Block.Rotate(Tetris.Block.getNextAngle(1));
                            
                                if(newPos.x+newBlockAdj.width>PlayWindow.width+PlayWindow.left)
                                    newPos.x = (PlayWindow.width+PlayWindow.left) - newBlockAdj.width;
                                if(newPos.y+newBlockAdj.height>PlayWindow.height+PlayWindow.top)
                                    newPos.x = (PlayWindow.height+PlayWindow.top) - newBlockAdj.height;

                                if(Tetris.IsCollided(new Point(newPos.x, newPos.y), newBlockAdj))
                                    isCanRotate = false;
                                else
                                    isCanRotate = true;
                            }
                            else
                                isCanRotate = true;

                            if(isCanRotate)
                            {
                                // can rotate, apply the new settings.
                                ptBlock    = newPos;
                                wrBlockAdj = newBlockAdj;
                            }
                            else
                                // can't rotate, restore old angle.
                                Tetris.Block.Rotate(saveAngle);
                            break;
                        case ConsoleKey.Escape:
                            isGameExit = true;
                            break;
                    }

                    if(!kb.Key.Equals(ConsoleKey.Spacebar))
                        if(!Tetris.IsCollided(new Point(newPos.x, newPos.y), wrBlockAdj))
                            ptBlock = newPos;
                    
                    if(ts.TotalSeconds<(DEFAULT_SPEED-(Speed-1)/10.0))
                        Tetris.Block.Draw(ptBlock, wrBlockAdj, isCanRotate);
                }

                if(ts.TotalSeconds>=(DEFAULT_SPEED-(Speed-1)/10.0))
                {
                    if((PlayWindow.height+PlayWindow.top)>(ptBlock.y+wrBlockAdj.height))
                        if(Tetris.IsCollided(new Point (ptBlock.x, ptBlock.y+1), wrBlockAdj))
                            // The block has collided, set the next block.
                            PlayBlock(nextBlock, false);
                        else
                            // move down
                            ptBlock.y++;
                    else
                        // Were at the bottom, set the next block.
                        PlayBlock(nextBlock, false);
                    
                    Tetris.Block.Draw(ptBlock, wrBlockAdj, isCanRotate);
                    stopWatch.Reset();
                    stopWatch.Start();
                }
            }

            stopWatch.Stop();

            // Press any key to exit.
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth - msg2.Length) / 2,
                                       Console.WindowHeight/2);
            Console.Write(msg2);
            Console.ReadKey();
            Console.ResetColor();

            sndEffect.Halt();
        }

        private static void Tetris_Process(object o, Game.EventArgs e)
        {
            if(e.RowsCompleted>0)
            {
                isRows = true;
                Score += e.RowsCompleted*(e.RowsCompleted>1?15:10);
                Lines += e.RowsCompleted;

                // Increase the speed according to the number of lines completed.
                if((Lines>=11) && (Lines<=20))
                    Speed = 2;
                else if((Lines>=21) && (Lines<=30))
                    Speed = 3;
                else if((Lines>=31) && (Lines<=40))
                    Speed = 4;
                else if((Lines>=41) && (Lines<=50))
                    Speed = 5;
                else if((Lines>=51) && (Lines<=60))
                    Speed = 6;
                else if((Lines>=61) && (Lines<=70))
                    Speed = 7;
                else if((Lines>=71) && (Lines<=80))
                    Speed = 8;
                else if((Lines>=81) && (Lines<=90))
                    Speed = 9;

                ShowStatus();   
            }
        }

        private static void ShowStatus()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+3, 2);
            Console.Write("Score");
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+3, 5);
            Console.Write("Lines");
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+3, 17);
            Console.Write("Speed");
            Console.ResetColor();
            
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+2, 3);
            Console.Write(String.Format("{0:D8}", Score));
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+2, 6);
            Console.Write(String.Format("{0:D8}", Lines));
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+5, 18);
            Console.Write(String.Format("{0:D2}", Speed));

            if(Lines>=100)
            {
                // CONGRATULATIONS!!!
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition((Console.WindowWidth - msg3.Length) / 2,
                                           Console.WindowHeight/2);
                Console.Write(msg3);
                Console.ReadKey();
                Console.ResetColor();

                sndEffect.Play(global::prjTetris.Properties.Resources.S104);
                isGameExit = true;
            }
        }

        private static void ShowNextBlock()
        {
            nextBlock = Tetris.Block.Generate(); // get next block

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+4, 8);
            Console.Write("Next");
            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+2, 9);
            Console.Write("¤¤¤¤¤¤¤¤");

            for(int i=1; i<=6; i++)
            {
                Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+2, i+9);
                Console.Write("¤      ¤");
            }

            Console.SetCursorPosition(PlayWindow.width+PlayWindow.left+2, 15);
            Console.Write("¤¤¤¤¤¤¤¤");
            Console.ResetColor();

            Tetris.Block.Preview(new Point(PlayWindow.width+PlayWindow.left+6, 12), nextBlock);
        }

        private static void PlayBlock(Game.StructBlock sbBlock, Boolean isNew)
        {
            if(isNew)
                // create new block
                sbBlock = Tetris.Block.Generate();
            else
                Tetris.SendToField(ptBlock, wrBlockAdj);

            Tetris.Block.Assign(sbBlock);
            Tetris.Block.Build();
            Tetris.Block.Adjustment(ref wrBlockAdj);     
      
            ptBlock.x = (PlayWindow.left-wrBlockAdj.left) + (PlayWindow.width-wrBlockAdj.width)/2;
            ptBlock.y =  PlayWindow.top;

            Tetris.Block.Draw(ptBlock, wrBlockAdj, true);            
            ShowNextBlock();

            if(Tetris.IsCollided(ptBlock, wrBlockAdj))
            {
                sndEffect.Play(global::prjTetris.Properties.Resources.S102);
                Console.SetCursorPosition((Console.WindowWidth - msg3.Length) / 2,
                                           Console.WindowHeight/2);
                Console.Write(msg3);

                isGameExit = true;
            }
            else
                if(isRows)
                {
                    // rows completed
                    sndEffect.Play(global::prjTetris.Properties.Resources.S103);
                    isRows = false;
                }
                else
                    sndEffect.Play(global::prjTetris.Properties.Resources.S100);
        }

        private static void GameDesign()
        {
            const string dsgnTB = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒";
            const string dsgnLR = "▒              ▒";
            
            // Define window size.
            PlayWindow.left   = 33;
            PlayWindow.width  = dsgnTB.Length-2;
            PlayWindow.top    = 2;
            PlayWindow.height = 19;

            // hide the cursor
            Console.CursorVisible = false;
            // help
            Console.SetCursorPosition(1, 1);
            Console.Write("-> , <- , DOWN => Move");
            Console.SetCursorPosition(1, 2);
            Console.Write(" UP , BARRA ESPAÇO => Roda ");
            Console.SetCursorPosition(1, 3);
            Console.Write("ENTER => PAUSA, CONTINUA ");

            // draw the top border
            Console.SetCursorPosition(PlayWindow.left-1, PlayWindow.top-1);
            Console.Write(dsgnTB);
            // draw the bottom border
            Console.SetCursorPosition(PlayWindow.left-1, PlayWindow.top+PlayWindow.height);
            Console.Write(dsgnTB);
            
            // draw the left and right border
            for(int i=PlayWindow.top; i<PlayWindow.height+PlayWindow.top ; i++)
            {
                Console.SetCursorPosition(PlayWindow.left-1, i);
                Console.Write(dsgnLR);
            }
            
            sndEffect.Play(global::prjTetris.Properties.Resources.S101);

            // PRESS ANY KEY TO START.
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition((Console.WindowWidth - msg5.Length) / 2,
                                       PlayWindow.height+PlayWindow.top+2);
            Console.Write(msg5);
            Console.ResetColor();
            Console.ReadKey();

            // clear the message from the bottom window
            ClearBottomLine();
        }

        private static void ClearBottomLine()
        {
            for(int i=1; i<Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, PlayWindow.height+PlayWindow.top+2);
                Console.Write(" ");
            }
        }
    }
}
