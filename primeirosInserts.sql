INSERT INTO tb_paciente (nome, email, celular, cpf)
VALUES ('lucas', 'lucas@gmail.com', '11970601233', '32121991870'),
		('Pedro', 'pedro@gmail.com', '1197875454', '33066241285')

select * from tb_paciente

INSERT INTO tb_especialidade	(nome, ativa)
VALUES ('Pamela', 1)
go

INSERT INTO tb_profissional (nome, ativo)
VALUES ('Pamela', 1)
GO


INSERT INTO tb_profissional_especialidade ( id_profissional, id_especialidade)
VALUES (1,1)


INSERT INTO tb_Consulta(data_horario, status, preco, pacienteId, especialidadeId, profissionalId)
VALUES ('2021-09-30 13:23:44', 1, 80.90, 1,1,1)
GO

INSERT INTO tb_Consulta(data_horario, status, preco, pacienteId, especialidadeId, profissionalId)
VALUES ('2021-09-30 13:23:44', 1, 80.90, 2,1,1)
GO

