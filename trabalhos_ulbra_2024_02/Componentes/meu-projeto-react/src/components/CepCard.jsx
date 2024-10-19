import { useEffect, useState } from "react";
import { useFetch } from "../hooks/useFetch";

function CepCard() {
    const [cepInput, setCepInput] = useState(null)
    const [data, error, loading] = useFetch(cepInput)

    function handleSubmit(event) {
        event.preventDefault()
        const formData = new FormData(event.target)
        const cep = formData.get("cep");
        const url = `https://viacep.com.br/ws/${cep}/json/`
        setCepInput(url)
    }

    return (
        <>
            <form onSubmit={handleSubmit}>
                <label>Cep: </label>
                <input 
                    name="cep"
                    type="text" 
                    placeholder="Digite o cep" 
                />
                <button>Pesquisar</button>
            </form>
            {loading && <p>Loading...</p>}
    {data && <p>{data.localidade} - {data.cep} - {data.logradouro} - {data.regiao}</p>}
    {error && <p>{error}</p>}
        </>
    )
}

export default CepCard;