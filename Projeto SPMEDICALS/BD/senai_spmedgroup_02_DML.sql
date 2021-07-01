--- Sprint DML

USE ProjetoMedicals;
GO

--- Inserção de Valores nas Tabelas

INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES					('Administrador'),
						('Medico'),
						('Paciente');
GO

--- Criando registros na tabela Usuario

INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES				(1, 'adm@adm.com', 'adm123'),
					(2, 'ricardo.lemos@spmedicalgroup.com.br', 'ricardo123'),
					(2, 'roberto.possarle@spmedicalgroup.com.br', 'possarle456'),
					(2, 'helena.souza@spmedicalgroup.com.br', 'helena789'),
					(3, 'ligia@gmail.com', 'ligia123'),
					(3, 'alexandre@gmail.com', 'alexandre456'),
					(3, 'fernando@gmail.com', 'fernando789'),
					(3, 'henrique@gmail.com', 'henrique987'),
					(3, 'joao@gmail.com', 'joao654'),
					(3, 'bruno@gmail.com', 'bruno123'),
					(3, 'mariana@outlook.com', 'mariana987')
GO

--- Criando registros na tabela Especialidade

INSERT INTO Especialidade	(Especialidade)
VALUES						('Acupuntera'),
							('Anestesiologia'),
							('Angiologia'),
							('Cardiologia'),
							('Cirurgia Cardiovascular'),
							('Cirurgia Da Mão'),
							('Cirurgia Do Aparelho Digestivo'),
							('Cirurgia Geral'),
							('Cirurgia Pediátrica'),
							('Cirurgia Plástica '),
							('Cirurgia Torácica'),
							('Cirurgia Vascular'),
							('Demartologia'),
							('RadioTerapia'),
							('Urologia'),
							('Pediatra'),
							('Psiquiatra ');	
GO

--- Cliando registro na tabela Clinica

INSERT INTO Clinica (NomeFantasia, Endereco, RazaoSocial, CNPJ)
VALUES				('Clinica Possarle', 'Av. Barão Limeira, 532', 'SP Médical Group', '86400902000130');
GO

--- Criando registros na tabela Medico

INSERT INTO Medico	(IdUsuario, IdEspecialidade, IdClinica, NomeMedico, CRM)
VALUES				(2, 2, 1,'Ricardo Lemos','54356-SP'),
				    (3, 17, 1, 'Roberto Possarle' ,'53852-SP'),
				    (4, 16, 1, 'Helena Strada' ,'65463-SP');
GO

--- Criando registros na tabela Paciente

INSERT INTO Paciente	(IdUsuario, NomePaciente, RG, CPF, Endereco, DataNascimento, Telefone)
VALUES					(5, 'Ligia', '435225435', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000', '10/03/1983', '1134567654'),
						(6, 'Alexandre', '326543457', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200', '07/03/2001', '11987656543'),
						(7, 'Fernando', '546365253', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200', '10/10/1978', '11972084453'),
						(8, 'Henrique', '543663625', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030', '13/10/1985', '1134566543'),
						(9, 'João', '325444441', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380', '27/08/1975', '1176566377'),
						(10, 'Bruno', '545662667', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001', '21/03/1972', '11954368769'),
						(11, 'Mariana', '545662668', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140', '05/03/2018', null);
GO

--- Criando registro na tabela Situacao

INSERT INTO Situacao	(Situacao)
VALUES					('Realizada'),
						('Agendada'),
						('Cancelada');
GO

--- Criando registros na tabela Consulta

INSERT INTO Consulta (IdPaciente, IdMedico, IdSituacao, DataConsulta, Descricao)
VALUES				 (7, 3, 1, '14/04/2021', 'Criança com catarro na garganta'),
					 (2, 2, 2, '28/03/2021', 'Paciente com falta de confiança em si mesmo'),
					 (3, 2, 1, '29/03/2021', 'Paciente com depressão severa'),
					 (2, 2, 1, '08/04/2021', 'Paciente com boderline'),
					 (4, 1, 2, '21/05/2021', 'Paciente verificando se tem alergia a anestesia utilizada na cirurgia'),
					 (7, 3, 3, '30/03/2021', 'Criança com dor de bronquilote'),
					 (4, 1, 3, '06/04/2021', 'Paciente com parestesia'),
					 (4, 1, 2, '09/10/2002', '');
GO
