<?php

namespace App\Controllers\Admin;
use App\Models\ClientModel;
use App\Controllers\BaseController;

class Client extends BaseController{
    
    var $ClientModel;

    public function __construct(){
        $this -> ClientModel = new ClientModel();
    }

    public function listClients(){
        $data = [
            'clients' => $this->ClientModel->findAll(),
        ];
        echo view('admin/templates/header');
        echo view('admin/client/listClients',$data);
        echo view('admin/templates/footer');
    }

    public function insertClient(){
        echo view('admin/templates/header');
        echo view('admin/client/insertClient');
        echo view('admin/templates/footer');
    }

    public function insertClientAction(){
        $data = [
            'name'=> $this -> request -> getVar('name'),
            'email'=> $this -> request -> getVar('email'),
            'phone'=> $this -> request -> getVar('phone'),
            'address'=> $this -> request -> getVar('address')
        ];
        $this->ClientModel -> insert($data);
        return redirect()->to(base_url('admin/listClients'));
    }

    
    public function updateClient($idClient){
        $data = [
            'client' => $this->ClientModel->find($idClient),
        ];
        echo view('admin/templates/header');
        echo view('admin/client/updateClient',$data);
        echo view('admin/templates/footer');
    }
   
    public function updateClientAction($idClient){
        $data = [
            'name'=> $this -> request -> getVar('name'),
            'email'=> $this -> request -> getVar('email'),
            'phone'=> $this -> request -> getVar('phone'),
            'address'=> $this -> request -> getVar('address')
        ];
        $this->ClientModel -> update($idClient, $data);
        return redirect()->to(base_url('admin/listClients'));
    }

    public function deleteClient($idClient){
        $this->ClientModel -> delete($idClient);
        return redirect()->to(base_url('admin/listClients'));
    }

    public function buscarClient(){
        echo view('admin/templates/header');
        echo view('admin/client/buscarClient');
        echo view('admin/templates/footer');
    }

    public function buscarClientAction() {
        $data = [
            'clients' => $this->ClientModel -> getSearchClient($_POST['pesquisa'])
        ];

        echo view('admin/templates/header');
        echo view('admin/client/detailsSearchClient', $data);
        echo view('admin/templates/footer');
    }
}