<h1>Listagem de clientes</h1>

<table class="table table-striped">

    <tr>
        <th>Código do cliente</th>
        <th>Nome</th>
        <th>Email</th>
        <th>Telefone</th>
        <th>Endereço</th>
        <th colspan="2">Ações</th>
    </tr>
<?php
    foreach ($clients as $client){  
?>
    <tr>
        <td>
            <?=$client['idClient']?>
        </td>
        <td>
            <?=$client['name']?>
        </td>
        <td>
            <?=$client['email']?>
        </td>
        <td>
            <?=$client['phone']?>
        </td>
        <td>
            <?=$client['address']?>
        </td>
        <td>
            <a href="<?=base_url('admin/updateClient/'.$client['idClient'])?>" class="btn btn-warning">
                Alterar
            </a>
        </td>
        <td>
            <a href="<?=base_url('admin/deleteClient/'.$client['idClient'])?>" class="btn btn-danger">
                Deletar
            </a>
        </td>
    </tr>
<?php
    }
?>

</table>
