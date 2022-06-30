$(document).ready(()=>{

    $('section').load('pages/home.html')
    $('#menuHome').addClass('active')

    function clearClass(params) {
        $('#menuHome').removeClass('active')
        $('#menuSobre').removeClass('active')
        $('#menuProduto').removeClass('active')
        $('#menuContato').removeClass('active')
    }

    $('#menuHome').click(()=>{
        clearClass()
        $('#menuHome').removeClass('active')
        $('section').load('pages/home.html')
    })

    $('#menuSobre').click(()=>{
        clearClass()
        $('#menuSobre').removeClass('active')
        $('section').load('pages/sobre.html')
    })
    
    $('#menuProduto').click(()=>{
        clearClass()
        $('#menuProduto').removeClass('active')
        $('section').load('pages/produtos.html')
    })
    
    $('#menuContato').click(()=>{
        clearClass()
        $('#menuContato').removeClass('active')
        $('section').load('pages/contato.html')
    })
})