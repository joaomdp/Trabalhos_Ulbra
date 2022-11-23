<?php
    class ContactModel {
        var $result;
        var $connection;

        public function __construct(){
            require_once('db/ConnectClass.php');
            $connectClass = new ConnectClass();
            $connectClass -> openConnect();
            $this -> connection = $connectClass -> getConn();
        }

        public function insertContact($arrayContact) {
            $name = $arrayContact['name'];
            $email = $arrayContact['email'];
            $message = $arrayContact['message'];
            
            $sql = "INSERT INTO contacts (name, email, message)
                VALUES('$name', '$email', '$message')";

            $this -> result = $this -> connection -> query($sql);
            $this -> result = $this -> connection -> insert_id;
        }

        public function consultContact() {
            $sql = "SELECT * FROM contacts";

            $this -> result = $this -> connection -> query($sql);
        }

        public function consultContactID($id) {
            $sql="SELECT * FROM contacts
                WHERE idContact = '$id'";

            $this -> result = $this -> connection -> query($sql);
        }

        public function returnResult() {
            return $this -> result;
        }
    }
?>