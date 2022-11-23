package com.example.notas.controller;

import com.example.notas.model.nota;
import com.example.notas.repository.NotaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/api")
public class NotaController {
    @Autowired
    NotaRepository notaRepository;

    //Recuperar todas as notas
    @GetMapping("/notes")
    public List<nota> getAllNotes(){
        return notaRepository.findAll();
    }

    @PostMapping("/notes")
    public nota createNote(@Valid @RequestBody nota Nota){
        return notaRepository.save(Nota);
    }
}
