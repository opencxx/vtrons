
set heading off;
set term off  ;
set feedback off;
set linesize 1000;
set pagesize 30000;
set trimout on;
set trimspool on;



--�¶Ⱦ���ͬ��
spool D:\HRV\TransformDB.v.1.0\V_DLP_YDJQTB.V_DLP_YDJQTB.csv; 
select trim(����||'|'||���¾���||'|'||�ΰ�����||'|'||��ͨ�¹�||'|'||Ⱥ������) from dsecs.V_DLP_YDJQTB;

--���վ���
spool D:\HRV\TransformDB.v.1.0\V_DLP_TODAY_ZZ.V_DLP_TODAY_ZZ.csv; 
select trim(��������||'|'||��Ч������||'|'||���¾���||'|'||�ΰ�����||'|'||��ͨ�¹�||'|'||Ⱥ������) from  dsecs.V_DLP_TODAY_ZZ;


--��������ռ��
spool D:\HRV\TransformDB.v.1.0\V_DLP_JRJQLX.v_dlp_jrjqlx.csv;
select trim(��������||'|'||�Ӿ����� ) from dsecs.v_dlp_jrjqlx;

--��ǹһ��Ͻ���ֲ�
spool D:\HRV\TransformDB.v.1.0\V_DLP_LQYDFB.V_DLP_LQYDFB.csv; 
select trim(��λ����||'|'||���� ) from  dsecs.V_DLP_LQYDFB ;

 
--��ǹһ��
spool D:\HRV\TransformDB.v.1.0\V_DLP_LQYD.V_DLP_LQYD.csv; 
select trim(ʱ��||'|'||������||'|'||Ħ�г�||'|'||����||'|'|| ���Ծ���||'|'|| ����||'|'||����||'|'|| ����||'|'|| ����һ������)  from  dsecs.V_DLP_LQYD  ;



--����ֵ��
spool D:\HRV\TransformDB.v.1.0\V_DLP_JRZB.V_DLP_JRZB.csv; 
select trim(ֵ������||'|'||ֵ�൥λ||'|'||ֵ��ֳ�||'|'||ֵ������||'|'||ֵ�೤||'|'||���||'|'||��� ) from  dsecs.V_DLP_JRZB where ֵ�൥λ in ('�����ع�����','���Ҷη־�','�����־�','«���־�','ʯ��־�','��Ԫ�־�','���ķ־�','�����ع�����','�����ع�����','���ع�����','�����й�����'); 


--����
-- spool D:\HRV\TransformDB.v.1.0\V_DLP_BDYZBL.V_DLP_BDYZBL.csv; 
-- select trim(ʱ��||'|'||����ɱ��||'|'||�����˺�||'|'||ǿ��||'|'|| ����||'|'||������Ʒ||'|'||�Ż�||'|'||��ը||'|'|| Ͷ��||'|'||��������)  from  dsecs.V_DLP_BDYZBL;

--���� ��
spool D:\HRV\TransformDB.v.1.0\V_DLP_XSJQLX.V_DLP_XSJQLX.csv; 
select trim(��������||'|'||�Ӿ�����)  from  dsecs.V_DLP_XSJQLX;



spool off;
exit;
