<?php

if(!isset($_GET['controller'])){
  require_once('controllers/SiteController.php');
  $SiteController = new SiteController();
  $SiteController -> home();
}else{
  switch ($_REQUEST['controller']) {
    case 'site':
      require_once('controllers/SiteController.php');
      $SiteController = new SiteController();
      if(!isset($_GET['action'])){
        $SiteController -> home();
      }else{
        switch ($_REQUEST['action']) {
          case 'home':
            $SiteController -> home();
          break;
          case 'about':
            $SiteController -> about();
          break;
          case 'products':
            $SiteController -> products();
          break;
          case 'contact':
            $SiteController -> contact();
          break;
        }
      }
    break; 

    case 'client':
      require_once('controllers/ClientController.php');
      $client = new ClientController();
      if(!isset($_GET['action'])){
          $client -> index();
      }else{
        switch($_REQUEST['action']){
          case 'register':
            $client -> register();
          break;
          case 'registerView':
            $client -> registerView();
          break;
          case 'listClients':
            $client -> listClients();
          break;
        }
      }
    break; 

    case 'product':
      require_once('controllers/ProductController.php');
      $product = new ProductController();
      if(!isset($_GET['action'])){
        $product -> index();
      }else{
        switch($_REQUEST['action']){
          case 'listProducts':
            $product -> listProducts();
          break;
      }
    }
    break;
  }  
}

