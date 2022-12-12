<h1>Detalhes do Cliente pesquisado</h1>

<?php
        foreach($clients as $client){
    ?>

<table class="table table-striped">
    <br>
    <tr>
        <th>Código do cliente</th>
        <td><?=$client['idClient']?></td>
    </tr>
    <tr>
        <th>Nome</th>
        <td><?=$client['name']?></td>
    </tr>
    <tr>
        <th>Email</th>
        <td><?=$client['email']?></td>
    </tr>
    <tr>
        <th>Telefone</th>
        <td><?=$client['phone']?></td>
    </tr>
    <tr>
        <th>Endereço</th>
        <td><?=$client['address']?></td>
    </tr>
</table>
    <button type="button" class="btn btn-outline-primary btn-sm"><a id="" class="nav-link" href="<?=base_url("/admin/client/buscar")?>">Voltar</a></button>
<?php
        }
    ?>

