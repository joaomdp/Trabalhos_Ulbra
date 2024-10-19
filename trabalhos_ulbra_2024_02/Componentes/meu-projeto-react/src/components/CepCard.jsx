import { useEffect, useState } from "react";
import { useFetch } from "../hooks/useFetch";

function CepCard() {
    const [cepInput, setCepInput] = useState(null);
    const [data, error, loading] = useFetch(cepInput);
    const [currentTime, setCurrentTime] = useState("");

    useEffect(() => {
        const now = new Date();
        const formattedTime = now.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
        setCurrentTime(formattedTime);
    }, [data]); 

    function handleSubmit(event) {
        event.preventDefault();
        const formData = new FormData(event.target);
        const cep = formData.get("cep");
        const url = `https://viacep.com.br/ws/${cep}/json/`;
        setCepInput(url);
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
            {data && !error && (
                <div>
                    <h3>Informações do CEP:</h3>
                    <p><strong>CEP:</strong> {data.cep}</p>
                    <p><strong>Cidade:</strong> {data.localidade}</p>
                    <p><strong>Bairro:</strong> {data.bairro}</p>
                    <p><strong>Rua:</strong> {data.logradouro}</p>
                    <p><strong>Horário da pesquisa:</strong> {currentTime}</p>
                </div>
            )}
            {error && <p>{error}</p>}
        </>
    );
}

export default CepCard;
