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

<?php
        }
    ?>

