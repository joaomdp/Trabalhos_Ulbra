<?php

class ProductModel{

    public function listProducts(){
        require_once('db/ConnectClass.php');
        $ConnectClass = new ConnectClass();
        $ConnectClass -> openConnect();
        $Connection = $ConnectClass -> getConn();

        $sql = "SELECT * FROM products";
        return $Connection -> query($sql);
    }
}