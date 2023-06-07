using TrabDupla.Classes;
//Dupla Felipe Las Casas e Rafael Emerick
Aluno aluno1 = new Aluno("João");
aluno1.email = "joão@email.com";

Minicurso minicurso1 = new Minicurso("Engenharia", 25, "ffsfsf.co.br");
Minicurso minicurso1 = new Minicurso(2022, 04, 01);
Registro registro1 = new Registro(2023, 06, 01);
registro1.RegistrarAtividade(minicurso1, aluno1);


