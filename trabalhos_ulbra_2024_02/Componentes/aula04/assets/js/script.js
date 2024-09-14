let contatos = [];

function navigate(page) {
    let content = document.getElementById('content');
    switch (page) {
        case 'home':
            content.innerHTML = `
                        <h1>Bem-vindo à Home</h1>
                        <p>Esta é a página inicial do nosso site.</p>
                    `;
            break;
        case 'contato':
            content.innerHTML = `
                        <h1>Formulário de Contato</h1>
                        <form id="contactForm">
                            <label for="nome">Nome:</label><br>
                            <input type="text" id="nome" name="nome" required><br><br>
                            <label for="email">Email:</label><br>
                            <input type="email" id="email" name="email" required><br><br>
                            <label for="telefone">Telefone:</label><br>
                            <input type="tel" id="telefone" name="telefone" required><br><br>
                            <button type="submit">Enviar</button>
                        </form>
                        <div id="resultTable"></div>
                    `;
            document.getElementById('contactForm').addEventListener('submit', function (event) {
                event.preventDefault();
                salvarContato();
            });
            break;
        case 'sobre':
            content.innerHTML = `
                        <h1>Sobre Nós</h1>
                        <p>Somos uma empresa fictícia criada para exemplificar o uso de SPA com formulários.</p>
                    `;
            break;
    }
}

function salvarContato() {
    const nome = document.getElementById('nome').value;
    const email = document.getElementById('email').value;
    const telefone = document.getElementById('telefone').value;

    const contato = {
        nome: nome,
        email: email,
        telefone: telefone
    };
    contatos.push(contato);

    exibirTabela();
}

function exibirTabela() {
    let table = `
                <table>
                    <tr>
                        <th>Nome</th>
                        <th>Email</th>
                        <th>Telefone</th>
                    </tr>
            `;

    contatos.forEach((contato) => {
        table += `
                    <tr>
                        <td>${contato.nome}</td>
                        <td>${contato.email}</td>
                        <td>${contato.telefone}</td>
                    </tr>
                `;
    });

    table += `</table>`;
    document.getElementById('resultTable').innerHTML = table;
}

window.onload = () => {
    navigate('home');
};
