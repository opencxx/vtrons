
set heading off;
set term off  ;
set feedback off;
set linesize 1000;
set pagesize 30000;
set trimout on;
set trimspool on;



--��ؔ
spool D:\HRV\TransformDB.v.1.0\V_DLP_QCLJQ.V_DLP_QCLJQ.csv; 
select trim(ʱ��||'|'||����||'|'||����||'|'||թƭ||'|'||����||'|'||��թ����||'|'||����թƭ)  from  dsecs.V_DLP_QCLJQ;


-- �ش���||'|'||�½��ı�
spool D:\HRV\TransformDB.v.1.0\V_DLP_ZDJQ.V_DLP_ZDJQ.csv
SELECT  trim(�Ӿ�Ա||'|'||to_char(����ʱ��,'YYYY-MM-DD')||'|'||to_char(����ʱ��,'HH24:mi:ss')||'|'||����||'|'||����) from  dsecs.V_DLP_ZDJQ; 

-- ������Ϣ
spool D:\HRV\TransformDB.v.1.0\V_DLP_GGXX.V_DLP_GGXX.csv
SELECT  trim(����||'|'||����||'|'||to_char(����ʱ��,'YYYY-MM-DD')||'|'||to_char(����ʱ��,'HH24:mi:ss')||'|'||������||'|'||ʧЧʱ��) from dsecs.V_DLP_GGXX;


-- �Ӿ�ϯλ -------------------------------- 
spool d:\HRV\TransformDB.v.1.0\V_DLP_CZLS.V_DLP_CZLS.csv; 
select trim(��ϯ��||'|'||�Ӿ�Ա����||'|'||��������||'|'||����ʱ��) from  dsecs.V_DLP_CZLS; 



-- ���¾���, ��ͨ�¹ʷֲ�
spool d:\HRV\TransformDB.v.1.0\V_DLP_QYAYFB.V_DLP_QYAYFB.csv; 
select trim(�����־�����||'|'||�������||'|'||to_char(count(*),'99999')) from dsecs.V_DLP_QYAYFB ;


-- ���վ���ֲ� -------------------------------- 
spool d:\HRV\TransformDB.v.1.0\V_DLP_JJXQ.V_DLP_JJXQ.csv; 
select trim(��������||'|'||��Ԫ�־�||'|'||«���־�||'|'||�����־�||'|'||ʯ��־�||'|'||���Ҷη־�||'|'||���ķ־�||'|'||�����ع�����||'|'||�����й�����||'|'||���ع�����||'|'||�����ع�����||'|'||�����ع�����) from  dsecs.V_DLP_JJXQ;


spool off;
exit;



