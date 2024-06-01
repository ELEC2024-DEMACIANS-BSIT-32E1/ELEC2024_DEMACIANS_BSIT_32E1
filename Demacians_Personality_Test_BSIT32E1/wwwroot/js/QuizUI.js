document.querySelectorAll('.scale-button').forEach(button => {
    button.addEventListener('click', () => {
        document.querySelectorAll('.scale-button').forEach(btn => btn.classList.remove('selected'));
        button.classList.add('selected');
        console.log('Selected value:', button.getAttribute('data-value'));
    });
});
