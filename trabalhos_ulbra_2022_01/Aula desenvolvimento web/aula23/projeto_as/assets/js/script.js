$(document).ready(()=>{

    $('section').load('pages/home.html')
    $('#menuHome').addClass('active')

    function clearClass(params) {
        $('#menuHome').removeClass('active')
        $('#menuClube').removeClass('active')
        $('#menuProduto').removeClass('active')
        $('#menuSocio').removeClass('active')
        $('#menuCasa').removeClass('active')
    }

    $('#menuHome').click(()=>{
        clearClass()
        $('#menuHome').removeClass('active')
        $('section').load('pages/home.html')
    })

    $('#menuClube').click(()=>{
        clearClass()
        $('#menuClube').removeClass('active')
        $('section').load('pages/clube.html')
    })
    
    $('#menuProduto').click(()=>{
        clearClass()
        $('#menuProduto').removeClass('active')
        $('section').load('pages/produtos.html')
    })
    
    $('#menuSocio').click(()=>{
        clearClass()
        $('#menuSocio').removeClass('active')
        $('section').load('pages/socio.html')
    })

    $('#menuCasa').click(()=>{
        clearClass()
        $('#menuCasa').removeClass('active')
        $('section').load('pages/casa.html')
    })
    
})

// FUNÇÃO VALIDAÇÃO
$("#FormValidation").validate({
    rules:{
        name:{
            minlenght:2
        },
        email:{
            email: true
        },
        phone:{
            Number:true,
            minlenght:10,
            maxlenght:10
        },
    },
    messages:{
        name:{
            required: "Por favor, digite seu nome completo",
            minlenght: "Seu nome deve ter no mínimo duas letras"
        },
        email:"Por favor, digite seu email",
        phone:"Por favor, digite seu número de telefone",
        sexo:"Por favor, insira seu sexo",
        formMessage:"Por favor, digite uma observação"
    },
    submitHandler: function(form) {
      form.submit();
    }
   });

function redirecionamneto() {
    window.location.replace("../index.html")
}