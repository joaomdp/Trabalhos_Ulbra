<?php
    class ContactController {
        var $ContactModel;
        var $UserController;

        public function __construct() {
            require_once("models/ContactModel.php");
            $this -> ContactModel = new ContactModel();

            require_once("controllers/UserController.php");
            $this -> UserController = new UserController();
        }

        public function insertContact() {
            $contactsJson = json_decode(file_get_contents('php://input'));

            $arrayContact['name'] = $contactsJson -> name;
            $arrayContact['email'] = $contactsJson -> email;
            $arrayContact['message'] = $contactsJson -> message;

            $this -> ContactModel -> insertContact($arrayContact);

            header("Content-Type: application/json");
            echo('{"result": true}');
        }

        public function consultContact() {
            if($this -> UserController -> isAdmin()) {
                $this -> ContactModel -> consultContact();
                $result = $this -> ContactModel -> returnResult();
    
                $arrayContacts = array();
                while($row = $result -> fetch_assoc()) {
                    array_push($arrayContacts, $row);
                }
                
                header("Content-Type: application/json");
                echo json_encode($arrayContacts);
            } else {
                header("Content-Type: application/json");
                echo json_encode('{"access": "denied"}');
            }
        }

        public function consultContactID($id) {
            if($this -> UserController -> isAdmin()) {
                $this -> ContactModel -> consultContactID($id);
                $result = $this -> ContactModel -> returnResult();

                $arrayClients = array();
                while($linha = $result -> fetch_assoc()) {
                    array_push($arrayClients, $linha);
                }

                header("Content-Type: application/json");
                echo json_encode($arrayClients);
            } else {
                header("Content-Type: application/json");
                echo json_encode('{"access": "denied"}');
            }
        }
    }
?>