-- Thu hoi quyen cua user/role:
create or replace procedure proc_revoke_user(ip_user in varchar2, ip_table in varchar2, ip_pos in varchar2) -- select, insert, delete
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
pos_name varchar2(20):= ip_pos;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    
    exec_commander:='REVOKE ' || pos_name || ' ON '|| table_name || ' FROM ' || user_name;
    EXECUTE IMMEDIATE(exec_commander);
    
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_revoke_user;
/
create or replace procedure proc_revoke_user_update(ip_user in varchar2, ip_table in varchar2, ip_column in varchar2) -- update
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
column_name varchar2(30):=ip_column;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    
    exec_commander:='REVOKE UPDATE' || '(' || column_name ||') ON '|| table_name ||' FROM ' || user_name;
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_revoke_user_update;
/
create or replace procedure proc_revoke_user_role(ip_user in varchar2, ip_role in varchar2)
is
user_name varchar2(20):= ip_user;
role_name varchar2(30):=ip_role;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='REVOKE ' || role_name || ' FROM ' || user_name;
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_revoke_user_role;

--exec proc_revoke_user('USER1', 'CSYT', 'SELECT');