--- Scripts DQL

USE ProjetoMedicals;

--- Script para visualizar as tabelas

SELECT * FROM TipoUsuario;
SELECT * FROM Usuario;
SELECT * FROM Especialidade;
SELECT * FROM Clinica;
SELECT * FROM Medico;
SELECT * FROM Paciente;
SELECT * FROM Situacao;
SELECT * FROM Consulta;

--- O administrador pode cadastrar qualquer tipo de us?ario (adimistrador, paciente ou m?dico)

SELECT IdUsuario, NomeTipoUsuario, Email
FROM Usuario
INNER JOIN TipoUsuario
ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario;

--- O administrador poder? agendar uma consulta, com as seguintes informa??es quem ? o paciente, 
--- data do agendamento e qual m?dico vai atender a consulta. o m?dico possui uma determinada especialidade

SELECT IdConsulta, NomePaciente, DataConsulta, CRM
FROM Consulta
INNER JOIN Medico
ON Medico.IdMedico = Consulta.IdConsulta
INNER JOIN Paciente
ON Paciente.IdPaciente = Consulta.IdPaciente;

--- O administrador poder? cancelar o agendamento das consultas

SELECT NomeTipoUsuario[Situacao], Email
FROM Usuario
INNER JOIN TipoUsuario
ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario
WHERE Email = 'marcos.adm@gmail.com';

--- O administrador tem que informar os dados da cl?nica (endere?o, CNPJ, nome fantasia e raz?o social)

SELECT IdClinica, Endereco, CNPJ, NomeFantasia, RazaoSocial
FROM Clinica

--- O m?dico poder? ver os agendamentos consultas associadas a ele

SELECT CRM, NomePaciente, DataConsulta, Descricao
FROM Consulta
INNER JOIN Medico
ON Medico.IdMedico = Consulta.IdMedico
INNER JOIN Paciente
ON Paciente.IdPaciente = Consulta.IdMedico
WHERE Medico.IdMedico = 3;

--- O m?dico poder? incluir a descri??o da consulta que estar? vinculada ao paciente

SELECT NomePaciente, Descricao
FROM Paciente
LEFT JOIN Consulta
ON Consulta.IdConsulta = Paciente.IdPaciente;

--- O paciente poder? visualizar suas pr?prias consultas

SELECT NomePaciente, DataConsulta, CRM, Descricao
FROM Paciente
INNER JOIN Consulta
ON Consulta.IdConsulta = Paciente.IdPaciente
INNER JOIN Medico
ON Medico.IdMedico = Paciente.IdPaciente;

