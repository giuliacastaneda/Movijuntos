window.addEventListener('DOMContentLoaded', () => {
    const viewMode = document.getElementById('view-mode');
    const viewNome = document.getElementById('view-nome');
    const viewApelido = document.getElementById('view-apelido');
    const viewEmail = document.getElementById('view-email');
    const viewNascimento = document.getElementById('view-nascimento');

    const editMode = document.getElementById('edit-mode');
    const inputNome = document.getElementById('input-nome');
    const inputApelido = document.getElementById('input-apelido');
    const inputNascimento = document.getElementById('input-nascimento');

    const btnEditar = document.getElementById('btn-editar');
    const btnSalvar = document.getElementById('btn-salvar');
    const btnCancelar = document.getElementById('btn-cancelar');

    const successMessage = document.getElementById('success-message');

    // --- Pegar ID da URL ---
    const params = new URLSearchParams(window.location.search);
    const userId = params.get('id');

    if (!userId) {
        alert('ID do usuário não encontrado. Redirecionando...');

        window.location.href = '/cadastrar/index.html';
        return;
    }

    async function carregarDadosDoPerfil() {
        try {
            const response = await fetch(`/api/usuario/${userId}`);
            if (!response.ok) throw new Error('Usuário não encontrado');

            const dados = await response.json();

            // Preencher modo visualização
            viewNome.textContent = dados.nome;
            viewApelido.textContent = dados.apelido;
            viewEmail.textContent = dados.email;
            viewNascimento.textContent = new Date(dados.nascimento).toLocaleDateString('pt-BR', { timeZone: 'UTC' });

            // Preencher modo edição
            inputNome.value = dados.nome;
            inputApelido.value = dados.apelido;
            inputNascimento.value = new Date(dados.nascimento).toISOString().split('T')[0];

        } catch (err) {
            console.error(err);
            alert('ID do usuário não encontrado. Redirecionando...');
            window.location.href = '/cadastrar/index.html';
        }
    }

    // Alternar modos
    btnEditar.addEventListener('click', () => {
        viewMode.classList.add('hidden');
        editMode.classList.remove('hidden');
    });

    btnCancelar.addEventListener('click', () => {
        editMode.classList.add('hidden');
        viewMode.classList.remove('hidden');
    });

    btnSalvar.addEventListener('click', async (e) => {
        e.preventDefault();
        const dadosAtualizados = {
            nome: inputNome.value,
            apelido: inputApelido.value,
            nascimento: inputNascimento.value
        };

        try {
            const response = await fetch(`/api/usuario/${userId}`, {
                method: 'PUT',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(dadosAtualizados)
            });

            if (response.ok) {
                successMessage.classList.remove('hidden');
                setTimeout(() => successMessage.classList.add('hidden'), 4000);
                await carregarDadosDoPerfil();
                editMode.classList.add('hidden');
                viewMode.classList.remove('hidden');
            } else {
                alert('Erro ao atualizar perfil.');
            }
        } catch (err) {
            console.error(err);
            alert('Falha na atualização.');
        }
    });

    carregarDadosDoPerfil();
});
