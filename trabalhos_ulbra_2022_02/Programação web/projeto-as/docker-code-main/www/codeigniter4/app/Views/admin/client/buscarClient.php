<h1>Buscar Cliente</h1>
<form  method="POST" action="<?=base_url("admin/client/buscar-action")?>">
    <div class="form-group">
        <div>
            <label for="pesquisa">Digite para buscar</label>
            <input type="text" class="form-control" name="pesquisa">
        </div>
        <br>
        <button type="submit" class="btn btn-success">Buscar</button>
    </div>
</form>

