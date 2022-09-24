<?php

class UserController{
    public function validateLogin(){
        $userName = $_POST['userName'];
        $password = $_POST['password'];
        require_once('models/UserModel.php');
        $UserModel = new UserModel();

        $result = $UserModel->consultUser($userName);

        if ($line = $result->fetch_assoc()) {
            if ($password == $line['password']) {
                $_SESSION['user'] = $line;
                header('location: index.php');
            } else {
                echo 'senha invalida';
            }
        } else {
            echo 'usuario não existente';
        }
    }
}
