<h1>Detalhes do cliente</h1>
<table class="table table-striped">
    <tr>
        <th>Código do cliente</th>
        <td>
            <?= $arrayClient['idClient'] ?>
        </td>
    </tr>
    <tr>
        <th>Nome</th>
        <td>
            <?= $arrayClient['name'] ?>
        </td>
    </tr>
    <tr>
        <th>Email</th>
        <td>
            <?= $arrayClient['email'] ?>
        </td>
    </tr>
    <tr>
        <th>Telefone</th>
        <td>
            <?= $arrayClient['phone'] ?>
        </td>
    </tr>
    <tr>
        <th>Endereço</th>
        <td>
            <?= $arrayClient['address'] ?>
        </td>
    </tr>
    <tr>
        <td>
            <button type="button" class="btn btn-outline-primary btn-sm"><a id="" class="nav-link" href="?controller=client&action=listClients">Voltar</a></button>
        </td>
    </tr>
</table>

