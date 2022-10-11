<h1>Alterando cliente</h1>
    <form class="form" action="?controller=client&action=updateClientAction&id=<?=$arrayClient['idClient']?>"method="post" enctype='multipart/form-data'>
        <div class="mb-3 mt-3">
            <label class="form-label">Nome</label>
            <input name="name" class="form-control" type="text" value="<?=$arrayClient['name']?>">
        </div>

        <div class="mb-3 mt-3">
            <label class="form-label">Email</label>
            <input name="email" class="form-control" type="email" value="<?=$arrayClient['email']?>">
        </div>

        <div class="mb-3 mt-3">
            <label class="form-label">Telefone</label>
            <input name="phone" class="form-control" type="text" value="<?=$arrayClient['phone']?>">
        </div>
        
        <div class="mb-3 mt-3">
            <label class="form-label">Endereço</label>
            <input name="address" class="form-control" type="text" value="<?=$arrayClient['address']?>">
        </div>

        <div class="mb-3 mt-3">
            <label class="form-label">Foto:</label>
            <input name="photo" class="form-control" type="file">
        </div>

        <div class="mb-3 mt-3">
            <?php
                if(is_file("assets/img/client/{$arrayClient['idClient']}.jpg")){
                    echo "<img style='max-width:150px' class='img-fluid' src='assets/img/client/{$arrayClient['idClient']}.jpg'>";
                }else{
                    echo 'Sem imagem';
                }
            ?>
        </div>

        <input class="btn btn-primary" type="submit" value="Enviar">
    </form>