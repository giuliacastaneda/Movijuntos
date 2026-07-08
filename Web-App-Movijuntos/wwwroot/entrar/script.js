// Definindo variáveis dos elementos do DOM
const btnLogin = document.getElementById('btnLogin');
const btnEsqueciSenha = document.getElementById('btnEsqueceuSenha');
const modal = document.getElementById('modalConfirmarEmail');
const spinner = btnLogin.querySelector('.spinner');
const btnText = document.createElement('span');
const btnCancelarCodigo = document.getElementById('btnCancelarCodigo');
const inputEmail = document.getElementById('inputEmail');
const inputSenha = document.getElementById('inputSenha');
const entrarForm = document.getElementById('entrarForm');
const btnConfirmarCodigo = document.getElementById('btnConfirmarCodigo');

// Configurando o botão de login com spinner
btnText.textContent = 'Entrar';
btnLogin.insertBefore(btnText, spinner);


// Adicionando eventos aos botões
btnLogin.addEventListener('click', async () => {

    if (entrarForm.checkValidity() === false) {
        entrarForm.reportValidity();
        return;
    }

    btnText.style.display = 'none';
    spinner.style.display = 'inline-block';
    btnLogin.style.pointerEvents = 'none';

    try {
        const resposta = await realizarLogin(inputEmail.value.trim(), inputSenha.value);
        if (resposta.success) {
            // Redireciona para a página de perfil com o id do usuário
            window.location.href = `/perfil/index.html?id=${resposta.userId}`;
        } else {
            alert("Usuário ou senha incorretos!");
        }
    } finally {
        spinner.style.display = 'none';
        btnText.style.display = 'inline';
        btnLogin.style.pointerEvents = 'auto';
    }
});

async function realizarLogin(email, senha) {
    const response = await fetch("/api/auth/login", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ Email: email, Senha: senha })
    });

    if (response.ok) {
        const data = await response.json();
        // Retorna sucesso e o id do usuário
        return { success: true, userId: data.usuarioId || data.UsuarioId };
    } else {
        return { success: false };
    }
}


btnEsqueciSenha.addEventListener('click', async () => {
    const email = inputEmail.value.trim();

    if (email === '' || !email.includes('@') || !email.includes('.') || !email.endsWith('.com')) {
        inputEmail.reportValidity();
        return;
    }

    btnText.style.display = 'none';
    spinner.style.display = 'inline-block';
    btnLogin.style.pointerEvents = 'none';

    try {
        const resposta = await fetch(`/api/usuario/esqueci-senha?email=${encodeURIComponent(email)}`, {
            method: "POST"
        });

        if (resposta.ok) {
            alert("Sucesso!");
        } else {
            alert("Errado!");
        }
    } finally {
        spinner.style.display = 'none';
        btnText.style.display = 'inline';
        btnLogin.style.pointerEvents = 'auto';
    }

    abrirModalConfirmarEmail();
});

btnCancelarCodigo.addEventListener('click', () => {
    modal.style.display = 'none';
});

// Adicionando as funções do sistema
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
    const email = inputEmail.value;
    const dados = {
        email: email,
        codigo: codigo
    };
    const resposta = await fetch("/api/auth/dverificador", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(dados)
    });
    if (resposta.ok) {
        alert('Código correto! A tela de redefinição de senha será feita em breve!');
    } else {
        alert('Insucesso! Código inválido.');
    }
});