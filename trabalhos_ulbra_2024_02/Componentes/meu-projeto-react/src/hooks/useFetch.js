import { useEffect, useState } from "react";

export function useFetch(url) {
    const [cep, setCep] = useState();
    const [error, setError] = useState();
    const [loading, setLoading] = useState();

    useEffect(() => {
        async function buscaCep() {
            setLoading(true)
            setError(false)
            setCep("")

            let resposta;
            try{
                 resposta = await fetch(url)
                 const cepJson = await resposta.json()
                 setCep(cepJson)
                 setLoading(false)
            } catch {
                setError("Error")
                setLoading(false)
            }
        }

        if (url != null) {
            buscaCep()
        }
    }, [url])

    return [cep, error, loading]
}