<h1>Listagem de clientes</h1>

<table class="table table-striped">

    <tr>
        <th>ID do cliente</th>
        <th>Nome</th>
        <th>Email</th>
        <th>Endereço</th>
        <th>Telefone</th>
        <th>Foto</th>
        <th colspan="2">Ações</th>
    </tr>
<?php
    foreach ($arrayClients as $client){  
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
            <?
                if(is_file("assets/img/client/{$client['idClient']}.jpg")){
                    echo "<img class='img-fluid' src='assets/img/client/{$client['idClient']}.jpg'";
                }else{
                    echo 'Sem imagem';
                }
            ?>
        </td>
        <td>
            <a href="?controller=client&action=detailsClient&id=<?=$client['idClient']?>" class="btn btn-info">
                Detalhes
            </a>
        </td>
        <td>
            <a href="?controller=client&action=updateClient&id=<?=$client['idClient']?>" class="btn btn-warning">
                Alterar
            </a>
        </td>
        <td>
            <a href="?controller=client&action=deleteClient&id=<?=$client['idClient']?>" class="btn btn-danger">
                Deletar
            </a>
        </td>
    </tr>
<?php
    }
?>

</table>
