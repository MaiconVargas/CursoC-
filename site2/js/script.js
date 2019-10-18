$(document).ready(
    function () {
        $('button[id="btnnome"]').click(function () {
            var nome = $('input[id="nome"]').val();
            alert("Seja bem vindo " + nome + " ao nosso sistema.");
        });
    }
);