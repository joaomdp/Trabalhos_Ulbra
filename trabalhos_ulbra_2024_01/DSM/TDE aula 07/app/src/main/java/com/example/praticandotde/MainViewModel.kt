package com.example.praticandotde
import androidx.lifecycle.ViewModel


class MainViewModel : ViewModel() {
    private val list = mutableListOf(
        Product(
            urlImage = "https://res.cloudinary.com/beleza-na-web/image/upload/w_1500,f_auto,fl_progressive,q_auto:eco,w_800/v1/imagens/products/B47949/THE-BLEND-EDP_V2_B47949_Conceito-2.jpg",
            name = "The Blend",
            price = "314,90"
        ),
        Product(
            urlImage = "https://farmashopweb.com.br/wp-content/uploads/2023/01/Botica-214-Dark-1.webp",
            name = "Botica 214",
            price = "184.90"
        ),
        Product(
            urlImage = "https://img.olx.com.br/images/38/385395191141492.jpg",
            name = "Malbec Magnetic",
            price = "224.90"
        ),
        Product(
            urlImage = "https://bagagemparadois.com.br/wp-content/uploads/2023/01/Isabels-Travel-Blog-2023-01-31T165536.525.jpg",
            name = "Arbo Intenso",
            price = "129.90"
        ),
        Product(
            urlImage = "https://res.cloudinary.com/beleza-na-web/image/upload/w_1500,f_auto,fl_progressive,q_auto:eco,w_800/v1/imagens/products/B81274/fotos_0011s_0003_ice4.jpg",
            name = "Quasar Ice",
            price = "129.90"
        ),
        Product(
            urlImage = "https://a-static.mlcdn.com.br/450x450/perfume-masculino-egeo-blue-90ml-de-o-boticario-o-boticario/sgwassistenciatecnica/9f7243d4870f11ed946b4201ac185019/a1b72f3bc331a4225661f40cbb07fdc8.jpeg",
            name = "Egeo Blue",
            price = "126.90"
        ),
        Product(
            urlImage = "https://m.media-amazon.com/images/I/51p9d9JIyJL._AC_UF1000,1000_QL80_.jpg",
            name = "Quasar Vision",
            price = "154.90"
        ),
        Product(
            urlImage = "https://production.na01.natura.com/on/demandware.static/-/Sites-natura-br-storefront-catalog/default/dw8802b7a6/produto-joia/background/mobile/53255.jpg",
            name = "Natura Homem",
            price = "179.90"
        ),
        Product(
            urlImage = "https://m.media-amazon.com/images/I/51JcETtGZwL._AC_UF1000,1000_QL80_.jpg",
            name = "Natura Essencial",
            price = "164.90"
        ),
        Product(
            urlImage = "https://production.na01.natura.com/on/demandware.static/-/Sites-natura-br-storefront-catalog/default/dw23040526/NATBRA-103348_3.jpg",
            name = "Natura Único",
            price = "294.90"
        )

    )
    fun getProducts() = list


    fun removeItem(index: Int) {
        list.removeAt(index)
    }
}
