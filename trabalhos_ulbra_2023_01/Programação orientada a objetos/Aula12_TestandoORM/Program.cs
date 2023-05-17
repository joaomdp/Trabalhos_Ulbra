﻿// See https://aka.ms/new-console-template for more information
using Aula12_TestandoORM.Data;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

var db = new MeuContexto();
Console.WriteLine($"Database path: {db.Database}.");

// Console.WriteLine("Inserting a new person");
// var person = new Person() {Id = 1, Nome = "João da Silva", PhoneNumber = "13257984987"}; 

IPersonRepository _personRepository = new PersonRepository(db);

// _personRepository.Save(person);

Console.WriteLine("----------------------");

var people = _personRepository.GetAll();

GetAllPeople();

Console.WriteLine("----------------------");

Console.WriteLine("Inserting a person using GetById");
var p = _personRepository.GetBayId(11);

 Console.WriteLine($"Id: {p.Id} | Nome: {p.Nome} | Phone {p.PhoneNumber}");

Console.WriteLine("----------------------");

//  Console.WriteLine("Deletando uma pessoa");
//  _personRepository.Delete(12);
// GetAllPeople();

Console.WriteLine("----------------------");

Console.WriteLine("Alterar uma pessoa");
p.Nome = "Gustavo teste update";
p.PhoneNumber = "45464564465";
_personRepository.Update(p);

Console.WriteLine("----------------------");
GetAllPeople();

 void GetAllPeople()
 {
    foreach (var item in people)
    {
        Console.WriteLine("Nova lista: ");
        var people = _personRepository.GetAll();
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Nome} | Phone {item.PhoneNumber}");
    }
 }