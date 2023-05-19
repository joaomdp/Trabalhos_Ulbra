﻿// See https://aka.ms/new-console-template for more information
using Aula12_TestandoORM.Data;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

var db = new MeuContexto();

// Console.WriteLine("----- Adicionar uma nova pessoa -----");
// var person = new Person() 
// {
//     Id = 3, 
//     Nome = "Lorenzo", 
//     PhoneNumber = "46578913",
//     City = new City()
//     {
//         Id = 1,
//         Name = "Arroio do Sal"
//     }
// }; 

// Console.WriteLine("----- Adicionar uma nova pessoa em uma cidade ja existente -----");
// ICityRepository _cityRepository = new CityRepository(db);
// var c = _cityRepository.GetById(1);

// var person = new Person() 
// {
//     Id = 3, 
//     Nome = "Lorenzo", 
//     PhoneNumber = "46578913",
//     City = c
// }; 

// IPersonRepository _personRepository = new PersonRepository(db);
// _personRepository.Save(person);

Console.WriteLine();

// Console.WriteLine("----- Listar pessoas -----");
// var people = _personRepository.GetAll();
// GetAllPeople();

Console.WriteLine();

// Console.WriteLine("----- Listar pessoa por ID -----");
// var p = _personRepository.GetById(2);
//  Console.WriteLine($"Id: {p.Id} | Nome: {p.Nome} | Phone {p.PhoneNumber}");

Console.WriteLine();

// Console.WriteLine("----- Deletar pessoa -----");
// _personRepository.Delete(2);
// GetAllPeople();

Console.WriteLine();

// Console.WriteLine("----- Atualizar pessoa -----");
// p.Nome = "Gustavo teste update";
// p.PhoneNumber = "45464564465";
// _personRepository.Update(p);

Console.WriteLine();

// GetAllPeople();

//  void GetAllPeople()
//  {
//     foreach (var item in people)
//     {
//         Console.WriteLine("Nova lista: ");
//         var people = _personRepository.GetAll();
//         Console.WriteLine($"Id: {item.Id} | Nome: {item.Nome} | Phone {item.PhoneNumber}");
//     }
//  }


// City
// Console.WriteLine("----- Adicionar nova cidade -----");
// var city  = new City() {Id = 3, Name = "Torres"};

// ICityRepository _cityRepository = new CityRepository(db);
// _cityRepository.Save(city);

Console.WriteLine();

// Console.WriteLine("----- Mostrar apenas uma cidade -----");
// var c = _cityRepository.GetById(1);
// Console.WriteLine($"Id: {c.Id} | Nome: {c.Name}");

Console.WriteLine();

// Console.WriteLine("----- Deletar uma cidade -----");
// _cityRepository.Delete(1);
// GetAllCities();

Console.WriteLine();

// Console.WriteLine("----- Atualizar uma cidade -----");
// c.Name = "Capão da Canoa";
// _cityRepository.Update(c);
// GetAllCities();

// void GetAllCities()
// {
//     Console.WriteLine("----- Lista de cidades -----");
//     var cities = _cityRepository.GetAll();
//     foreach (var item in  cities)
//     {
//         Console.WriteLine($"Id: {item.Id} | Nome: {item.Name}");
//     }
// }
