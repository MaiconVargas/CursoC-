using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{        
    enum RotationEnum
    {
        deg0   = 0,
        deg90  = 1,
        deg180 = 2,
        deg270 = 3
    }

    enum BlockTypeNum
    {
        block01 = 0,
        block02 = 1,
        block03 = 2,
        block04 = 3,
        block05 = 4,
        block06 = 5,
        block07 = 6
    }

    struct StructBlock
    {
        public RotationEnum angle;
        public BlockTypeNum type;

        public StructBlock(RotationEnum newAngle, BlockTypeNum newType)
        {
            this.angle = newAngle;
            this.type  = newType;
        }
    }

    struct StructBlockStyle
    {
        public ConsoleColor color;
        public Boolean      isBlock;

        public StructBlockStyle(ConsoleColor newColor, Boolean newIsBlock)
        {
            this.color   = newColor;
            this.isBlock = newIsBlock;
        }
    }

    public delegate void TetrisHandler(object o, EventArgs e);

    public class EventArgs
    {
        public readonly int RowsCompleted;

        public EventArgs(int r)
        {
            RowsCompleted = r;
        }
    }

    class BaseClass
    {
        protected static int BLOCK_SIZE = 4; // size of the block(4v4)

        protected static bool[] arrBlock         = new bool[BLOCK_SIZE<<2]; 
        protected static WindowRect TetrisField  = new WindowRect();    
        protected static Point       m_blockpos  = new Point();
        protected static StructBlock m_block     = new StructBlock();
        protected static StructBlockStyle[] arrField;
    }

    class BlockClass : BaseClass
    {
        public RotationEnum Angle
        {
            get
            {
                return m_block.angle;
            }
            set
            {
                m_block.angle = value;
            }
        }

        public BlockTypeNum Type
        {
            get 
            {
                return m_block.type;
            }
            set
            {
                m_block.type = value;
            }
        }

        public Point Location
        {
            get 
            {
                return new Point(m_blockpos.x, m_blockpos.y);
            }
            set
            {
                m_blockpos = value;
            }
        }   

        public int Size
        {
            get 
            {
                return BLOCK_SIZE;
            }
        }

        public ConsoleColor Color(BlockTypeNum typBlock)
        {
            // this function returns the color of the block.
            switch(typBlock)
            {
                case BlockTypeNum.block01:
                    return ConsoleColor.Red;
                case BlockTypeNum.block02:
                    return ConsoleColor.Blue;
                case BlockTypeNum.block03:
                    return ConsoleColor.Cyan;
                case BlockTypeNum.block04:
                    return ConsoleColor.Yellow;
                case BlockTypeNum.block05:
                    return ConsoleColor.Green;
                case BlockTypeNum.block06:
                    return ConsoleColor.Magenta;
                default:
                    return ConsoleColor.DarkCyan;
            }
        }

        public StructBlock Generate()
        {
            Random rnd = new Random();

            // pick random pieces
            return new StructBlock((RotationEnum)rnd.Next(0, Enum.GetNames(typeof(RotationEnum)).Length),
                                   (BlockTypeNum)rnd.Next(0, Enum.GetNames(typeof(BlockTypeNum)).Length));
        }

        public WindowRect Rotate(RotationEnum newAngle)
        {
            WindowRect wrBlock = new WindowRect();

            Angle = newAngle;
            Build();
            Adjustment(ref wrBlock);
           
            return wrBlock;
        }

        public void Build()
        {
            // Get the data for the block.
            arrBlock = GetBlockData(new StructBlock(Angle, Type));
        }

        public Boolean[] GetBlockData(StructBlock structBlock)
        {
            // 0123
            // 4567
            // 8901
            // 2345

            // data for 4v4 block shapes
            bool[] arrData = new bool[BLOCK_SIZE<<2];
            
            switch(structBlock.type)
            {
                case BlockTypeNum.block01:
                    if(structBlock.angle.Equals(RotationEnum.deg0) ||
                       structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[2]  = true; // ..#. 0123
                        arrData[6]  = true; // ..#. 4567
                        arrData[10] = true; // ..#. 8901
                        arrData[14] = true; // ..#. 2345
                    }
                    else
                    {
                        arrData[12] = true; // .... 0123
                        arrData[13] = true; // .... 4567
                        arrData[14] = true; // .... 8901
                        arrData[15] = true; // #### 2345
                    }

                    break;
                case BlockTypeNum.block02:
                    arrData[0]  = true; // ##.. 0123
                    arrData[1]  = true; // ##.. 4567
                    arrData[4]  = true; // .... 8901
                    arrData[5]  = true; // .... 2345
                    break;
                case BlockTypeNum.block03:
                    if(structBlock.angle.Equals(RotationEnum.deg0) ||
                       structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[5]  = true; // .... 0123
                        arrData[6]  = true; // .##. 4567
                        arrData[8]  = true; // ##.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    else
                    {
                        arrData[1]  = true; // .#.. 0123
                        arrData[5]  = true; // .##. 4567
                        arrData[6]  = true; // ..#. 8901
                        arrData[10] = true; // .... 2345
                    }
                    break;
                case BlockTypeNum.block04:
                    if(structBlock.angle.Equals(RotationEnum.deg0) ||
                       structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[4]  = true; // .... 0123
                        arrData[5]  = true; // ##.. 4567
                        arrData[9]  = true; // .##. 8901
                        arrData[10] = true; // .... 2345
                    }
                    else
                    {
                        arrData[2]  = true; // ..#. 0123
                        arrData[5]  = true; // .##. 4567
                        arrData[6]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    break;
                case BlockTypeNum.block05:
                    if(structBlock.angle.Equals(RotationEnum.deg0))
                    {
                        arrData[4]  = true; // .... 0123
                        arrData[5]  = true; // ###. 4567
                        arrData[6]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg90))
                    {
                        arrData[1]  = true; // .#.. 0123
                        arrData[4]  = true; // ##.. 4567
                        arrData[5]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[5]  = true; // .... 0123
                        arrData[8]  = true; // .#.. 4567
                        arrData[9]  = true; // ###. 8901
                        arrData[10] = true; // .... 2345
                    }
                    else
                    {
                        arrData[1]  = true; // .#.. 0123
                        arrData[5]  = true; // .##. 4567
                        arrData[6]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    break;
                case BlockTypeNum.block06:
                    if(structBlock.angle.Equals(RotationEnum.deg0))
                    {
                        arrData[4]  = true; // .... 0123
                        arrData[5]  = true; // ###. 4567
                        arrData[6]  = true; // #... 8901
                        arrData[8]  = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg90))
                    {
                        arrData[0]  = true; // ##.. 0123
                        arrData[1]  = true; // .#.. 4567
                        arrData[5]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[6]  = true; // .... 0123
                        arrData[8]  = true; // ..#. 4567
                        arrData[9]  = true; // ###. 8901
                        arrData[10] = true; // .... 2345
                    }
                    else
                    {
                        arrData[1]  = true; // .#.. 0123
                        arrData[5]  = true; // .#.. 4567
                        arrData[9]  = true; // .##. 8901
                        arrData[10] = true; // .... 2345
                    }
                    break;
                case BlockTypeNum.block07:
                    if(structBlock.angle.Equals(RotationEnum.deg0))
                    {
                        arrData[4]  = true; // .... 0123
                        arrData[5]  = true; // ###. 4567
                        arrData[6]  = true; // ..#. 8901
                        arrData[10] = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg90))
                    {    
                        arrData[1]  = true; // .#.. 0123
                        arrData[5]  = true; // .#.. 4567
                        arrData[8]  = true; // ##.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    else if(structBlock.angle.Equals(RotationEnum.deg180))
                    {
                        arrData[4]  = true; // .... 0123
                        arrData[8]  = true; // #... 4567
                        arrData[9]  = true; // ###. 8901
                        arrData[10] = true; // .... 2345
                    }
                    else
                    {
                        arrData[1]  = true; // .##. 0123
                        arrData[2]  = true; // .#.. 4567
                        arrData[5]  = true; // .#.. 8901
                        arrData[9]  = true; // .... 2345
                    }
                    break;
            }

            return arrData;
        }

        public void Adjustment(ref WindowRect wrBlock)
        {
            Adjustment(ref wrBlock, arrBlock);
        }

        public void Adjustment(ref WindowRect wrBlock, bool[] arrData)
        {
            //  This function returns the exact measurement of the block. 
            
            wrBlock = new WindowRect();

            int  col;
            int  row;
            bool isAdj;

            //  Check empty colums from the left-side of the block, and if found, 
            // increase the left margin.
            isAdj = true;
            for(col=0; col<BLOCK_SIZE; col++)
            {
                for(row=0; row<BLOCK_SIZE; row++)
                    if(arrData[col+row*BLOCK_SIZE])
                    {
                        isAdj = false;
                        break;
                    }
                
                if(isAdj)
                    // left margin
                    wrBlock.left++;
                else
                    break;
            }
            // end left adjustment

            //  Check empty rows from the top-side of the block, and if found, 
            // increse the top margin. 
            isAdj = true;
            for(row=0; row<BLOCK_SIZE; row++)
            {
                for(col=0; col<BLOCK_SIZE; col++)
                    if(arrData[col+row*BLOCK_SIZE])
                    {
                        isAdj = false;
                        break;
                    }
                
                if(isAdj)
                    wrBlock.top++;
                else
                    break;
            }
            // end top adjustment

            //  Check empty columns from the right-side of the block, and if found, 
            // increase the right margin.
            isAdj = true;
            for(col=BLOCK_SIZE-1; col>=0; col--)
            {
                for(row=0; row<BLOCK_SIZE; row++)
                    if(arrData[col+row*BLOCK_SIZE])
                    {
                        isAdj = false;
                        break;
                    }
                
                if(isAdj)
                    wrBlock.width++;
                else
                    break;
            }

            // get the exact width of the block
            wrBlock.width = BLOCK_SIZE - (wrBlock.left+wrBlock.width);
            // end right adjustment

            //  Check empty rows from the bottom-side of the block, and if found, 
            // increase the bottom.
            isAdj = true;
            for(row=BLOCK_SIZE-1; row>=0; row--)
            {
                for(col=0; col<BLOCK_SIZE; col++)
                    if(arrData[col+row*BLOCK_SIZE])
                    {
                        isAdj = false;
                        break;
                    }
                
                if(isAdj)
                    // bottom margin
                    wrBlock.height++;
                else
                    break;
            }

            // get the exact height of the block.
            wrBlock.height = BLOCK_SIZE - (wrBlock.top+wrBlock.height);
            // end top adjustment;
        }

        public void Draw(Point pt, WindowRect wrBlockAdj, Boolean isRotateUpdate)
        {
            // Draw the block.
            if(!Location.x.Equals(pt.x) || !Location.y.Equals(pt.y) || isRotateUpdate)
            {
                TetrisClass.DrawField(pt, wrBlockAdj);
                Console.ForegroundColor = Color(Type);
                for(int row=wrBlockAdj.top; row<wrBlockAdj.top+wrBlockAdj.height; row++)
                    for(int col=wrBlockAdj.left; col<wrBlockAdj.left+wrBlockAdj.width; col++)
                        if(arrBlock[col+row*BLOCK_SIZE])  
                        {
                            Console.SetCursorPosition(pt.x+col-wrBlockAdj.left, pt.y+row-wrBlockAdj.top);
                            Console.Write("#");
                        }
                Console.ResetColor();

                Location = pt;
            }
        }

        public void Preview(Point pt, StructBlock structBlock)
        {
            // shows a preview of a block
            WindowRect wrBlockAdj = new WindowRect();
            bool[] arrData        = GetBlockData(structBlock);
            
            //  retrieve the exact measurement of the block
            // so we can able to draw the block in correct position.
            Adjustment(ref wrBlockAdj, arrData);

            Console.ForegroundColor = Color(structBlock.type);
            for(int row=wrBlockAdj.top; row<wrBlockAdj.top+wrBlockAdj.height; row++)
                for(int col=wrBlockAdj.left; col<wrBlockAdj.left+wrBlockAdj.width; col++)
                    if(arrData[col+row*BLOCK_SIZE])  
                    {
                        Console.SetCursorPosition(pt.x+col-wrBlockAdj.left-wrBlockAdj.width/2, 
                                                  pt.y+row-wrBlockAdj.top-wrBlockAdj.height/2);
                        Console.Write("#");
                    }
            Console.ResetColor();
        }

        public RotationEnum getNextAngle(int rotateOption)
        {
            if(rotateOption.Equals(0))
                // clockwise
                switch(Angle)
                {
                    case RotationEnum.deg0:
                        return RotationEnum.deg90;
                    case RotationEnum.deg90:
                        return RotationEnum.deg180;
                    case RotationEnum.deg180:
                        return RotationEnum.deg270;
                    default:
                        return RotationEnum.deg0;
                }
            else
                // counter-clockwise
                switch(Angle)
                {
                    case RotationEnum.deg0:
                        return RotationEnum.deg270;
                    case RotationEnum.deg270:
                        return RotationEnum.deg180;
                    case RotationEnum.deg180:
                        return RotationEnum.deg90;
                    default:
                        return RotationEnum.deg0;
                }
        }

        public void Assign(StructBlock sbNew)
        {
            Angle = sbNew.angle;
            Type  = sbNew.type;   
        }
    }

    class TetrisClass : BaseClass
    {
        public event TetrisHandler ProcessEvent;

        public BlockClass Block = new BlockClass();

        public TetrisClass(WindowRect wrField)
        {
            TetrisField = wrField;
            BuildField();
        }

        public void BuildField()
        {
            arrField = new StructBlockStyle[TetrisField.width*
                                            TetrisField.height];
        }

        public static void DrawField(Point pt, WindowRect wrBlockAdj)
        {
            int w = TetrisField.width;
            int h = TetrisField.height;

            for(int row=0; row<h; row++)
                for(int col=0; col<w; col++)
                {
                    if(((StructBlockStyle)arrField[col+row*w]).isBlock)
                    {
                        Console.ForegroundColor = ((StructBlockStyle)arrField[col+row*w]).color;
                        Console.SetCursorPosition(TetrisField.left+col, TetrisField.top+row);
                        Console.Write("@");
                    }
                    else
                    {
                        Console.SetCursorPosition(TetrisField.left+col, TetrisField.top+row);
                        Console.Write(" ");
                    }
                }

            Console.ResetColor();
        }

        public bool IsCollided(Point pt, WindowRect wrBlockAdj)
        {
            int sx = pt.x - TetrisField.left;
            int sy = pt.y - TetrisField.top;
            int w  = TetrisField.width;

            int blockIndex;
            int fieldIndex;

            for(int row=0; row<wrBlockAdj.height; row++)
                for(int col=0; col<wrBlockAdj.width; col++)
                {
                    blockIndex = (wrBlockAdj.left+col)+((wrBlockAdj.top+row)*BLOCK_SIZE);
                    fieldIndex = ((sx+sy*w)+col)+row*w;

                    if(arrBlock[blockIndex] && ((StructBlockStyle)arrField[fieldIndex]).isBlock)
                       return true;
                }

            return false;
        }

        public void SendToField(Point pt, WindowRect wrBlockAdj)
        {
            // This function sends the block data to field.
            int blockIndex;
            int fieldIndex;

            for(int row=0; row<wrBlockAdj.height; row++)
                for(int col=0; col<wrBlockAdj.width; col++)
                {
                    blockIndex = (wrBlockAdj.left+col)+
                                 (wrBlockAdj.top+row)*
                                  Block.Size;
                    fieldIndex = (pt.x-TetrisField.left+col)+
                                 (pt.y-TetrisField.top+row)*
                                  TetrisField.width;

                    if(arrBlock[blockIndex])
                        arrField[fieldIndex] = new StructBlockStyle(Block.Color(Block.Type), true);
                }

            ProcessRows();
        }

        public void ProcessRows()
        {
            // This function check to see if rows were completed.
            int w           = TetrisField.width;
            int h           = TetrisField.height;
            int rowCounter  = h-1;
            int rowTotal    = 0;
            bool isFullLine = true;

            // Store rows that are not completed.
            StructBlockStyle[] arrData = new StructBlockStyle[TetrisField.width*
                                                              TetrisField.height];

            for(int row=h-1; row>=0; row--)
            {
                for(int col=w-1; (col>=0) && isFullLine; col--)
                    if(!((StructBlockStyle)arrField[col+row*w]).isBlock)
                        isFullLine = false;
                
                if(!isFullLine)
                {
                    // copy the row
                    for(int col=w-1; col>=0; col--)
                        arrData[col+rowCounter*w] = arrField[col+row*w];

                    rowCounter--;
                    isFullLine = true;
                }
                else
                    // Do not include rows that are completed.
                    rowTotal++;
            }

            // get all the rows that are not completed.
            arrField = arrData; 

            EventArgs e = new EventArgs(rowTotal);
            RaiseEvent((object)this, e);
        }

        private void RaiseEvent(object o, EventArgs e)
        {
            if (ProcessEvent != null)
                ProcessEvent(o, e);
        }

    }
}