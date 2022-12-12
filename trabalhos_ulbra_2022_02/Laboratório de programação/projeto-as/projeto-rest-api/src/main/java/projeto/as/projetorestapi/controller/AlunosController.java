package projeto.as.projetorestapi.controller;

import lombok.AllArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import projeto.as.projetorestapi.model.AlunosModel;
import projeto.as.projetorestapi.repository.AlunoRepository;

import java.util.Optional;

@RestController
@AllArgsConstructor
public class AlunosController {

    @Autowired
    private AlunoRepository repository;

    @GetMapping(path = "/api/alunos")
    public Iterable<AlunosModel> getAllAlunos(){
        return repository.findAll();
    }

    @GetMapping(path = "/api/aluno/{id}")
    public ResponseEntity consultar(@PathVariable("id") Integer id){
       return repository.findAllById(id)
               .map(record -> ResponseEntity.ok().body(record))
               .orElse(ResponseEntity.notFound().build());
   }

   @PostMapping(path = "/api/aluno/salvar")
   public AlunosModel salvar(@RequestBody AlunosModel aluno){
        return repository.save(aluno);
   }

   @DeleteMapping(path = "/api/aluno/deletar/{id}")
    public void deleteAluno(@PathVariable Integer id){
        repository.deleteById(id);
   }

   @PutMapping(path = "/api/aluno/atualizar")
    public void alterar(@RequestBody AlunosModel aluno){
        repository.save(aluno);
   }

}
