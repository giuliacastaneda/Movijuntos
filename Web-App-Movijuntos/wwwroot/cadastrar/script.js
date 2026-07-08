// Selecionando os elementos do DOM
const btnCadastrar = document.getElementById('btnCadastrar');
const modal = document.getElementById('modalConfirmarEmail');
const spinner = btnCadastrar.querySelector('.spinner');
const btnText = document.createElement('span');
const btnCancelarCodigo = document.getElementById('btnCancelarCodigo');
const cadastrarForm = document.getElementById('cadastrarForm');
const senhaField = document.getElementById('senhaField');
const senhaConfirmarField = document.getElementById('senhaConfirmarField');
const msgErro = document.getElementById('msgErro');
const nomeField = document.getElementById('nomeField');
const userField = document.getElementById('userField');
const nascimentoField = document.getElementById('nascimentoField');
const emailField = document.getElementById('emailField');
const codigoField = document.getElementById('codigoField');
const btnConfirmarCodigo = document.getElementById('btnConfirmarCodigo');
const regex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_])[^\s]{6,}$/;

// Configurando o botão de cadastro com spinner
btnText.textContent = 'Cadastrar';
btnCadastrar.insertBefore(btnText, spinner);

// Impedindo data atual e futura
nascimentoField.max = new Date(Date.now() - 86400000).toISOString().split('T')[0];

// Adicionando eventos aos botões

btnCadastrar.addEventListener('click', async () => {
    if (cadastrarForm.checkValidity() === false) {
        cadastrarForm.reportValidity();
        return;
    }

    if (!/^[A-Za-zÀ-ÿ\s]+$/.test(nomeField.value.trim())) {
        abrirMsgErro('Nome deve conter apenas letras.');
        return;
    }

    if (userField.value.trim().includes(' ')) {
        abrirMsgErro('Nome de usuário não pode conter espaço.');
        return;
    }

    if (!regex.test(senhaField.value)) {
        abrirMsgErro('A senha não satisfaz os critérios acima.');
        return;
    }

    if (senhaField.value !== senhaConfirmarField.value) {
        abrirMsgErro('As senhas devem ser iguais.');
        return;
    }

    btnText.style.display = 'none';
    spinner.style.display = 'inline-block';
    btnCadastrar.style.pointerEvents = 'none';


    await cadastrarUsuario();


    spinner.style.display = 'none';
    btnText.style.display = 'inline';
    btnCadastrar.style.pointerEvents = 'auto';
});

async function cadastrarUsuario() {
    const usuario = {
        nome: nomeField.value.trim(),
        apelido: userField.value.trim(),
        email: emailField.value.trim(),
        nascimento: nascimentoField.value,
        senha: senhaField.value,
    };

    let response;
    try {
        response = await fetch("/api/usuario", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(usuario)
        });
    } catch (err) {
        abrirMsgErro('Erro de conexão. Tente novamente.');
        return;
    }


    let mensagem = '';
    try {
        const text = await response.text();

        try {
            const j = JSON.parse(text);
            mensagem = j.message || j.error || text;
        } catch {
            mensagem = text || response.statusText;
        }
    } catch {
        mensagem = response.statusText;
    }

    if (response.status === 201 || response.status === 200) {

        abrirModalConfirmarEmail();

        codigoField.value = '';
        setTimeout(() => codigoField.focus(), 300);

        return;
    }

    if (response.status === 409) {

        abrirMsgErro(mensagem || 'E-mail ou apelido já cadastrado.');
        return;
    }

    if (response.status === 400) {

        abrirMsgErro(mensagem || 'Dados inválidos. Verifique e tente novamente.');
        return;
    }

    abrirMsgErro(mensagem || `Erro inesperado: ${response.status}`);
}

btnCancelarCodigo.addEventListener('click', () => {
    modal.style.display = 'none';
});

// Adicionando as funções do sistema
function abrirMsgErro(texto) {
    msgErro.textContent = texto;
    setTimeout(() => {
        msgErro.innerHTML = '&nbsp;';
    }, 2000);
}
function abrirModalConfirmarEmail() {

    modal.style.display = 'block';
    btnCancelarCodigo.style.pointerEvents = 'none';

    for (let i = 5; i >= 0; i--) {
        setTimeout(() => {
            if (i !== 0)
                btnCancelarCodigo.textContent = `Cancelar (${i}s)`;
            else
                btnCancelarCodigo.textContent = 'Cancelar';
        }, ((5 - i) * 1000))
    }

    setTimeout(() => {
        btnCancelarCodigo.style.pointerEvents = 'auto';
    }, 5000);

}

btnConfirmarCodigo.addEventListener('click', async () => {
    const codigo = codigoField.value;
    const email = emailField.value;
    const dados = { email, codigo };

    // Verifica o código
    const resposta = await fetch("/api/auth/dverificador", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(dados)
    });

    if (resposta.ok) {
        // Se o código estiver correto, pega o userId pelo email
        const idResponse = await fetch(`/api/usuario/idporEmail?email=${encodeURIComponent(email)}`);
        if (idResponse.ok) {
            const idData = await idResponse.json();
            alert('Cadastro realizado com sucesso! Redirecionando...');
            window.location.href = `../perfil?id=${idData.userId}`;
        } else {
            alert('Não foi possível recuperar o ID do usuário.');
        }
    } else {
        alert('Erro ao verificar código.');
    }
});
