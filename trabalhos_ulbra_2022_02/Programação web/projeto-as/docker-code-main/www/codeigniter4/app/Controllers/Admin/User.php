<?php

namespace App\Controllers\Admin;

use App\Controllers\BaseController;
use App\Models\UserModel;

class User extends BaseController{

    public function validateLogin(){
        $userName = $this->request->getVar('userName');
        $userPassword = $this->request->getVar('userPassword');

        $UserModel = new UserModel();
        $session = \Config\Services::session();

        if ($user = $UserModel->getUser($userName)) {    

            if ($user['password'] == $userPassword) {
                $session->set('user', $user);
                return redirect()->to(base_url('/admin'));
            } else {
                    //senha inválida
                    $session->set('error', 'Senha inválida');
                    return redirect()->to(base_url('/admin/login'));
                    }
                } else {
                    //usuário não existe
                    $session->set('error', 'Usuário não existe');
                    return redirect()->to(base_url('admin/login'));
                }
            }
        }
