﻿// See https://aka.ms/new-console-template for more information
using Aula12_TestandoORM.Data;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

var db = new MeuContexto();
ICarroRepository _carroRepository = new CarroRepository(db);
IEstacionamentoRepository _estacionamentoRepository = new EstacionamentoRepository(db);

// Console.WriteLine("----- Adicionar um novo carro -----");
// var carro = new Carro() 
// {
//     Id = 1, 
//     Marca = "Toyota", 
//     Modelo = "Hillux",
//     Estacionamento = new Estacionamento()
//     {
//         Id = 3
//     }
// }; 
// _carroRepository.Save(carro);
// GetAllCarros();

Console.WriteLine();

// Console.WriteLine("----- Adicionar mais um carro na mesma vaga -----");
// var c = _estacionamentoRepository.GetById(2);

// var carro = new Carro() 
// {
//     Id = 1, 
//     Marca = "Hyunday update", 
//     Modelo = "Sonata update",
//     Estacionamento = c
// }; 

// _carroRepository.Save(carro);
// GetAllCarros();

Console.WriteLine();

// Console.WriteLine("----- Listar carros estacionados -----");
// var c = _carroRepository.GetAll();
// GetAllCarros();

Console.WriteLine();

// Console.WriteLine("----- Listar carro por ID -----");
// var vaga = _estacionamentoRepository.GetById(2);
// var carro = _carroRepository.GetById(2);
// Console.WriteLine($"Id: {carro.Id} | Marca: {carro.Marca} | Modelo {carro.Modelo} | Vaga: {carro.Estacionamento.Id}");

Console.WriteLine();

// Console.WriteLine("----- Deletar carro -----");
// _carroRepository.Delete(1);
// GetAllCarros();

Console.WriteLine();

// Console.WriteLine("----- Deletar estacionamento -----");
// _estacionamentoRepository.Delete();
// GetAllCarros();

Console.WriteLine();

// Console.WriteLine("----- Atualizar carro -----");
// var carro = _carroRepository.GetById(2);
// carro.Marca = "Fiat";
// carro.Modelo = "Cronos";
// _carroRepository.Update(carro);

Console.WriteLine();

 void GetAllCarros()
 {
    var c = _carroRepository.GetAll();
    foreach (var item in c)
    {
        Console.WriteLine("Nova lista: ");
        var vaga = _estacionamentoRepository.GetAll();
        var carro = _carroRepository.GetAll();
        Console.WriteLine($"Id: {item.Id} | Marca: {item.Marca} | Modelo: {item.Modelo} | Vaga: {item.Estacionamento.Id}");
    }
 }

 
