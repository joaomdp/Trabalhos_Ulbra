<!DOCTYPE html>
<html lang="pt-br">

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<title>Projeto AS</title>

	<!-- bootstrap -->
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>

	<!-- JS e CSS -->
	<script src="assets/js/script.js"></script>
	<link rel="stylesheet" href="<?=base_url("assets/css/style-public.css")?>">

</head>

<body>
	<header class="container-fluid text-white bg-dark p-5 text-center">
		<h1>Meu projeto AS</h1>
	</header>
	
	<div class="container-fluid">
		<div class="row">
			<nav class="col-md-3 p-3">
				<h2 class="h2">Menu</h2>

				<hr>
				
				<ul class="nav flex-column">
					<li class="nav-item">
						<a id="btnHome" class="nav-link" href="<?=base_url('home')?>">Home</a>
					</li>
					<li class="nav-item">
						<a id="btnAbout" class="nav-link" href="<?=base_url('about')?>">Sobre</a>
					</li>
					<li class="nav-item">
						<a id="btnProducts" class="nav-link" href="<?=base_url('products')?>">Produtos e serviços</a>
					</li>
					<li class="nav-item">
						<a id="btnContact" class="nav-link" href="<?=base_url('contact')?>">Contatos</a>
					</li>
				</ul>

				<h2 class="h2">Clientes</h2>

				<hr>
				<ul class="nav flex-column">
					<li class="nav-item">
						<a id="" class="nav-link" href="<?=base_url('listClients')?>">Listagem de Clientes</a>
					</li>
				</ul>

			</nav>

			<section class="col-md-9 p-3">