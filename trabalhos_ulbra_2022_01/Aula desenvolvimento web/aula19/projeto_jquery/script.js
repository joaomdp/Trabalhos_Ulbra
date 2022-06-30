$(document).ready(function () {

    $('section').load('home.html')

    $('#menu_home').click(function () {
        $('section').load('home.html')
    })

    $('#menu_calculadora').click(function () {
        $('section').load('calculadora.html', function () {
            $('#calcular').click(function () {

                var n1 = parseFloat($('#n1').val())
                var n2 = parseFloat($('#n2').val())
                var operacao = $('#operacao').val()
                var resultado;

                switch (operacao) {
                    case '+':
                        resultado = n1 + n2;
                        break;
                    case '-':
                        resultado = n1 - n2
                        break;
                    case '*':
                        resultado = n1 * n2
                        break;
                    case '/':
                        resultado = n1 / n2
                        break;
                }
                $('#resultado').html('O resultado é ' + resultado)
            })
        })
    })

});


