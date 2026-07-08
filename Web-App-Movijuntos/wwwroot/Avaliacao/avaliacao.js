// ======= ESTRELAS =======
const stars = document.querySelectorAll('.star');
const notaInput = document.getElementById('nota');

stars.forEach((star, index) => {
    star.addEventListener('click', () => {
        // Remove seleção anterior
        stars.forEach(s => s.classList.remove('selected'));
        // Marca as estrelas até a clicada
        for (let i = 0; i <= index; i++) {
            stars[i].classList.add('selected');
        }
        // Salva a nota
        notaInput.value = index + 1;
    });
});

// ======= UPLOAD (limite e formatos permitidos) =======
const inputFotos = document.getElementById('fotos');
inputFotos.addEventListener('change', (e) => {
    const arquivos = e.target.files;
    const tiposPermitidos = ['image/png', 'image/jpeg', 'application/pdf', 'image/x-raw'];

    if (arquivos.length > 2) {
        alert('Você só pode enviar no máximo 2 arquivos.');
        e.target.value = '';
        return;
    }

    for (const arquivo of arquivos) {
        if (!tiposPermitidos.includes(arquivo.type)) {
            alert(`Arquivo inválido: ${arquivo.name}. Formatos permitidos: PNG, JPG, JPEG, PDF, RAW.`);
            e.target.value = '';
            return;
        }
    }
});

// ======= ENVIO DO FORMULÁRIO =======
document.getElementById('avaliacaoForm').addEventListener('submit', async function (e) {
    e.preventDefault();

    const data = {
        Nota: parseInt(notaInput.value || 0),
        Rampas: document.querySelector('input[name="rampas"]:checked')?.value === 'sim' ? 1 : 0,
        Corrimaos: document.querySelector('input[name="corrimaos"]:checked')?.value === 'sim' ? 1 : 0,
        BanheirosAcessiveis: document.querySelector('input[name="banheiros"]:checked')?.value === 'sim' ? 1 : 0,
        VagasReservadas: document.querySelector('input[name="vagas"]:checked')?.value === 'sim' ? 1 : 0,
        SinalizacaoTatil: document.querySelector('input[name="tatil"]:checked')?.value === 'sim' ? 1 : 0,
        SinalizacaoVisualSonora: document.querySelector('input[name="visual"]:checked')?.value === 'sim' ? 1 : 0,
        LarguraPortasCorredores: document.querySelector('input[name="portas"]:checked')?.value === 'sim' ? 1 : 0,
        CaminhosLivres: document.querySelector('input[name="obstaculos"]:checked')?.value === 'sim' ? 1 : 0,
        Comentario: document.getElementById('comentario').value
    };

    const response = await fetch('/api/avaliacao', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(data)
    });

    const mensagem = document.getElementById('mensagem');

    if (response.ok) {
        mensagem.textContent = '✅ Avaliação enviada com sucesso!';
        mensagem.style.color = 'green';

        // Reset visual e campos
        this.reset();
        notaInput.value = '';
        stars.forEach(s => s.classList.remove('selected'));
        inputFotos.value = '';
    } else {
        mensagem.textContent = '❌ Erro ao enviar avaliação.';
        mensagem.style.color = 'red';
    }
});
