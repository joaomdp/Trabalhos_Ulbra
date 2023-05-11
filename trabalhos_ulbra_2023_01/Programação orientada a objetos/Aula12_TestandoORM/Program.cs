﻿// See https://aka.ms/new-console-template for more information
using Aula12_TestandoORM.Data;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;

var db = new MeuContexto();
Console.WriteLine($"Database path: {db.Database}.");

Console.WriteLine("Inserting a new person");
var person = new Person() {Id = 1, Nome = "João da Silva", PhoneNumber = "132456789"}; 
db.Add(person);
db.SaveChanges();