package projeto.as.projetorestapi.repository;

import org.springframework.data.repository.CrudRepository;
import projeto.as.projetorestapi.model.AlunosModel;

import java.util.Optional;

public interface AlunoRepository extends CrudRepository<AlunosModel, Integer> {
    Optional<Object> findAllById(Integer id);
}
