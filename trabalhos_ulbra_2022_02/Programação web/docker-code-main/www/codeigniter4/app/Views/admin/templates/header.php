<!DOCTYPE html>
<html lang="pt-br">

<head>
	<meta charset="UTF-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0" />
	<title>Projeto AS</title>
	<!-- jquery -->
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
	<!-- bootstrap -->
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
	<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
	<script src="<?=base_url("assets/js/script.css")?>" ></script>
	<link rel="stylesheet" href="<?=base_url("assets/css/style-adm.css")?>" />
</head>

<body>
	<header class="container-fluid p-5 text-center">
		<h1>Área Administrativa</h1>
		<a href="<?=base_url("admin/logout")?>">Sair</a>
	</header>
	<div class="container-fluid">
		<div class="row">
			<nav class="p-3 col-md-3">
				<h2>Menu</h2>
				<hr>
				<ul class="nav flex-column">
					<li class="nav-item">
						<a class="nav-link" href="<?=base_url("admin")?>">Home</a>
					</li>
				</ul>
				<h3>Clientes</h3>
				<hr>
				<ul class="nav flex-column">
					<li class="nav-item">
						<a class="nav-link" href="<?=base_url("admin/listClients")?>">Listar Clientes</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="<?=base_url("admin/insertClient")?>">Cadastrar Cliente</a>
					</li>
					<li class="nav-item">
						<a class="nav-link" href="<?=base_url('admin/client/buscar')?>">Buscar</a>
					</li>
				</ul>
			</nav>
			<section class="p-3 col-md-9">