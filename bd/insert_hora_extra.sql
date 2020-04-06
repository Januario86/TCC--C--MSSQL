INSERT INTO 
dbo.hora_extra(qtd_hora_extra,dt_hr_extra,Empregador_id_empregador,
Funcionario_id_funcionario)VALUES(4,'01/09/2015 5:27:01 PM',
(select id_empregador from Funcionario where id_funcionario =12),12)

