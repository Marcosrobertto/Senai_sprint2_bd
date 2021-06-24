--- Sprint DML

USE ProjetoMedicals;
GO

--- Inser��o de Valores nas Tabelas

INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES					('Administrador'),
						('Medico'),
						('Paciente');
GO

--- Criando registros na tabela Usuario

INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES				(1, 'marcos.adm@gmail.com', 'Marcos123'),
					(2, 'Sarinha44@gmail.com', 'Sara123'),
					(2, 'Derek_mm@gmail.com', 'Derek123'),
					(3, 'Lele02@gmail.com', 'Leticia123'),
					(3, 'Brenda32@gmail.com', 'Brebda222'),
					(3, 'Devid6@gmail.com', 'David'),
					(3, 'pedrada2@gmail.com', 'Pedro123'),
					(2, 'Kaio99@gmail.com', 'Kaio123'),
					(2, 'ester@gmail.com', 'Ester123'),
					(2, 'raquel23@gmail.com', 'Raquel123');
GO

--- Criando registros na tabela Especialidade

INSERT INTO Especialidade	(Especialidade)
VALUES						('Acupuntera'),
							('Anestesiologia'),
							('Angiologia'),
							('Cardiologia'),
							('Cirurgia Cardiovascular'),
							('Cirurgia Da M�o'),
							('Cirurgia Do Aparelho Digestivo'),
							('Cirurgia Geral'),
							('Cirurgia Pedi�trica'),
							('Cirurgia Pl�stica '),
							('Cirurgia Tor�cica'),
							('Cirurgia Vascular'),
							('Demartologia'),
							('RadioTerapia'),
							('Urologia'),
							('Pediatra'),
							('Psiquiatra ');	
GO

--- Cliando registro na tabela Clinica

INSERT INTO Clinica (NomeFantasia, Endereco, RazaoSocial, CNPJ)
VALUES				('Clinica Marcos', 'Av. Luis Gomes Bandeiras 234, S�o Paulo - SP', 'Medical Group', '44555678744613');
GO

--- Criando registros na tabela Medico

INSERT INTO Medico	(IdUsuario, IdEspecialidade, IdClinica, NomeMedico, CRM)
VALUES				(2, 4, 1, 'Sara Silva', '45332 - SP'),
					(3, 8, 1, 'Derek Santo', '63985 - SP'),
					(5, 16, 1, 'Brenda Santos','97652- SP'),
					(8, 17, 1, 'Kaio Silva', '88456 - SP');
GO

--- Criando registros na tabela Paciente

INSERT INTO Paciente	(IdUsuario, NomePaciente, RG, CPF, Endereco, DataNascimento, Telefone)
VALUES					(4, 'Leticia Silva', '509548889', '57565633224', 'Rua Baltzar Barroso, 20 - Guaianazes, S�o Paulo - SP - 99654-346', '20/02/2000', '11 20655312'),
						(6, 'David', '678798435', '54642131689', 'Av. Paulista, 654 - Bela Vista , S�o Paulo - SP - 95679-921', '06/05/1997', '11 85639612'),
						(7, 'Pedro Souza', '129482301', '89890328443', 'Rua Luis Gomes, 344 - Jardim Moreno, S�o Paulo - SP - 12354-023', '12/12/1998', '11 95644535'),
						(9, 'Ester Silva', '894020760', '86940345265', 'Av. Bandeira Gomes, 543 - Jardim Das Bandeiras, S�o Paulo - SP - 89545-981', '24/11/2001', '11 43894534');
GO

--- Criando registro na tabela Situacao

INSERT INTO Situacao	(Situacao)
VALUES					('Realizada'),
						('Agendada'),
						('Cancelada');
GO

--- Criando registros na tabela Consulta

INSERT INTO Consulta (IdPaciente, IdMedico, IdSituacao, DataConsulta, Descricao)
VALUES				 (1, 1, 1, '13/11/2019', 'Doen�a arterial perif�rica'),
					 (2, 1, 1, '20/12/2019', 'Cardiopatia cong�nita'),
					 (2, 3, 1, '28/12/2019', 'Caxumba'),
					 (4, 3, 3, '03/04/2020', 'Infec��es no ouvido e na garganta'),
					 (2, 3, 3, '07/05/2020', 'Catapora'),
					 (3, 4, 2, '16/05/2021', 'Transtorno bipolar'),
					 (1, 4, 2, '19/11/2021', 'Transtornos de Ansiedade');
GO
