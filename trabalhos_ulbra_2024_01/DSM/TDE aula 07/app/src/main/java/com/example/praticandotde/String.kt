package com.example.praticandotde

fun String.convertToMoneyWithSymbol() = "R$ ".plus(this.replace(".", ","))