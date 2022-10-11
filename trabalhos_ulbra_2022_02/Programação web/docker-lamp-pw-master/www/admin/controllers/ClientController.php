<?php

class ClientController{

    var $ClientModel;

    public function __construct(){
        if(!isset($_SESSION['user'])){
            header('Location:?controller=main&action=login');
        }
        require_once('models/ClientModel.php');
        $this-> ClientModel = new ClientModel();
    }

    public function register(){
        require_once('views/templates/header.php');
        require_once('views/client/register.php');
        require_once('views/templates/footer.php');
    }
    public function registerView(){
        if (isset($_POST['accept'])) {
            $accept = true;
            $accept = "Termo aceito.";
        }else{
            $accept = false;
            $accept = "Termo não aceito.";
        }

        $arrayClient = array(
            'name' => $_POST['name'],
            'email' => $_POST['email'],
            'phone' => $_POST['phone'],
            'gender' => $_POST['gender'],
            'accept' => $accept,
        );

        require_once('views/templates/header.php');
        require_once('views/client/registerView.php');
        require_once('views/templates/footer.php');
    }

    public function listClients(){
        require_once('models/ClientModel.php');
        $result = $this -> ClientModel -> listClients();

        $arrayClients =  array();
        while($line = $result -> fetch_assoc()){
            array_push($arrayClients, $line);
        }
        require_once('views/templates/header.php');
        require_once('views/client/listClients.php');
        require_once('views/templates/footer.php');
    }

    public function detailsClient($idClient){
        require_once('models/ClientModel.php');
        $result = $this -> ClientModel -> consultClient($idClient);

        if ($arrayClient = $result->fetch_assoc()) {
            require_once('views/templates/header.php');
            require_once('views/client/detailsClient.php');
            require_once('views/templates/footer.php');
        }
    }

    public function insertClient(){
        require_once('views/templates/header.php');
        require_once('views/client/insertClient.php');
        require_once('views/templates/footer.php');   
    }

    public function insertClientAction(){

        $client = array(
            'name' => $_POST['name'],
            'phone' => $_POST['phone'],
            'email' => $_POST['email'],
            'address' => $_POST['address']
        );
        
        $idClient = $this -> ClientModel -> insertClient($client);
        if(isset($_FILES["photo"]) && $_FILES['photo']['name'] !=''){
            $this -> savePhoto($idClient);
        }
        
        header('Location:?controller=client&action=listClients');
    }

    public function updateClient($idClient){
        require_once('models/ClientModel.php');
        $result = $this -> ClientModel -> consultClient($idClient);

        if ($arrayClient = $result->fetch_assoc()) {
            require_once('views/templates/header.php');
            require_once('views/client/updateClient.php');
            require_once('views/templates/footer.php');
        }
    }

    public function updateClientAction($idClient){
        $client = array(
            'idClient' => $idClient,
            'name' => $_POST['name'],
            'phone' => $_POST['phone'],
            'email' => $_POST['email'],
            'address' => $_POST['address']
        );

        $this -> ClientModel -> updateClient($client);
        if(isset($_FILES["photo"]) && $_FILES['photo']['name'] !=''){
            $this -> savePhoto($idClient);
        }
        header('Location:?controller=client&action=listClients');
    }

    public function deleteClient($idClient){
        $this -> ClientModel -> deleteClient($idClient);
        if(is_file("assets/img/client/{$idClient}.jpg")){
            unlink("assets/img/client/{$idClient}.jpg");
        }
        header('Location:?controller=client&action=listClients');
    }

    public function savePhoto($id){
    $foto_temp = $_FILES["photo"]["tmp_name"];	//pega o caminho temporário do arquivo
    $foto_name = $_FILES["photo"]["name"];		//pega o nome

    $extensao = str_replace('.','',strrchr($foto_name, '.')); 

    // Carrega a imagem 
    $img = null;

    //Transforma a imagem em JPG
    if ($extensao == 'jpg' || $extensao == 'jpeg') { 
        $img = imagecreatefromjpeg($foto_temp);
    } else if ($extensao == 'png') { 
        $img = imagecreatefrompng($foto_temp);
    } else if ($extensao == 'gif') { 
        $img = imagecreatefromgif($foto_temp); 
    }  else         
        $img = imagecreatefromjpeg($foto_temp); 

	//cria imagem no diretório @imagejpeg($img,"diretorio/".$id_noticia) se já tiver com este nome vai substituir
	$localFile = "assets/img/client/{$id}.jpg";
	imagejpeg($img, $localFile); 
    }
}