$(document).ready(()=>{
    $('section').load('pages/home.html')

    $('#btnHome').click(()=>{
        $('section').load('pages/home.html')
    })

    $('#btnAbout').click(()=>{
        $('section').load('pages/about.html')
    })

    $('#btnProducts').click(()=>{
        $('section').load('pages/products.html')
    })

    $('#btnContact').click(()=>{
        $('section').load('pages/contact.html')
    })
    
})