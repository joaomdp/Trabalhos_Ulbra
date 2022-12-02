<?php

namespace App\Controllers\Admin;

use App\Controllers\BaseController;
use App\Models\UserModel;

class User extends BaseController{

    public function validateLogin(){
        $userName = $this->request->getVar('login');
        $userPassword = $this->request->getVar('password');

        $UserModel = new UserModel();

        if ($user = $UserModel->getUser($userName)) {
            $session = \Config\Services::session();
            $session->set('user', $user);
            if ($user['password'] == $userPassword) {
                $session->set('user', $user);
                return redirect()->to(base_url('/admin'));
            } else {
                    //senha inválida
                    return redirect()->to(base_url('/admin/login'));
                    }
                } else {
                    //usuário não existe
                    return redirect()->to(base_url('admin'));
                }
            }
        }
