-- Thong tin quyen cua moi user/role tren cac doi tuong du lieu:
create or replace procedure proc_user_table(ip_user in varchar2, temp OUT SYS_REFCURSOR)
is
begin
    open temp for
    SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = ip_user;
commit;
end proc_user_table;
/
-- Gan quyen cho user:
create or replace procedure proc_user_select(ip_user in varchar2, ip_table in varchar2, check01 in number) -- select
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
check_grant number(1):=check01;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    if check_grant = 0 then
        exec_commander:='GRANT SELECT ON '|| table_name || ' TO ' || user_name;
        EXECUTE IMMEDIATE(exec_commander);
    else
        exec_commander:='GRANT SELECT ON '|| table_name || ' TO ' || user_name || ' WITH GRANT OPTION';
        EXECUTE IMMEDIATE(exec_commander);
    end if;
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_user_select;
/
create or replace procedure proc_user_insert(ip_user in varchar2, ip_table in varchar2, check01 in number) -- insert
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
check_grant number(1):=check01;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    if check_grant = 0 then
        exec_commander:='GRANT INSERT ON '|| table_name || ' TO ' || user_name;
        EXECUTE IMMEDIATE(exec_commander);
    else
        exec_commander:='GRANT INSERT ON '|| table_name || ' TO ' || user_name || ' WITH GRANT OPTION';
        EXECUTE IMMEDIATE(exec_commander);
    end if;
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_user_insert;
/
create or replace procedure proc_user_delete(ip_user in varchar2, ip_table in varchar2, check01 in number) -- delete
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
check_grant number(1):=check01;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    if check_grant = 0 then
        exec_commander:='GRANT DELETE ON '|| table_name || ' TO ' || user_name;
        EXECUTE IMMEDIATE(exec_commander);
    else
        exec_commander:='GRANT DELETE ON '|| table_name || ' TO ' || user_name || ' WITH GRANT OPTION';
        EXECUTE IMMEDIATE(exec_commander);
    end if;
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_user_delete;
/
create or replace procedure proc_user_update(ip_user in varchar2, ip_table in varchar2, ip_column in varchar2, check01 in number) -- update
is
user_name varchar2(20):= ip_user;
table_name varchar2(30):=ip_table;
column_name varchar2(30):=ip_column;
check_grant number(1):=check01;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    if check_grant = 0 then
        exec_commander:='GRANT UPDATE' || '(' || column_name ||') ON '|| table_name ||' TO ' || user_name;
        EXECUTE IMMEDIATE(exec_commander);
    else
        exec_commander:='GRANT UPDATE' || '(' || column_name ||') ON '|| table_name ||' TO ' || user_name || ' WITH GRANT OPTION';
        EXECUTE IMMEDIATE(exec_commander);
    end if;
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_user_update;
/
-- Cap quyen cho role:
create or replace procedure proc_role_select(ip_role in varchar2, ip_table in varchar2) -- select
is
role_name varchar2(20):= ip_role;
table_name varchar2(30):=ip_table;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='GRANT SELECT ON '|| table_name || ' TO ' || role_name;
    EXECUTE IMMEDIATE(exec_commander);
        
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_role_select;
/
create or replace procedure proc_role_insert(ip_role in varchar2, ip_table in varchar2) -- insert
is
role_name varchar2(20):= ip_role;
table_name varchar2(30):=ip_table;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='GRANT INSERT ON '|| table_name || ' TO ' || role_name;
    EXECUTE IMMEDIATE(exec_commander);
        
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_role_insert;
/
create or replace procedure proc_role_delete(ip_role in varchar2, ip_table in varchar2) -- delete
is
role_name varchar2(20):= ip_role;
table_name varchar2(30):=ip_table;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='GRANT DELETE ON '|| table_name || ' TO ' || role_name;
    EXECUTE IMMEDIATE(exec_commander);
        
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_role_delete;
/
create or replace procedure proc_role_update(ip_role in varchar2, ip_table in varchar2, ip_column in varchar2) -- update
is
role_name varchar2(20):= ip_role;
table_name varchar2(30):=ip_table;
column_name varchar2(30):=ip_column;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);

    exec_commander:='GRANT UPDATE' || '(' || column_name ||') ON '|| table_name ||' TO ' || role_name;
    EXECUTE IMMEDIATE(exec_commander);
        
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_role_update;
/
-- Cap role cho user:
create or replace procedure proc_user_role(ip_user in varchar2, ip_role in varchar2, check01 in number)
is
user_name varchar2(20):= ip_user;
role_name varchar2(30):=ip_role;
check_grant number(1):=check01;
exec_commander varchar(1000);
begin
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
    EXECUTE IMMEDIATE(exec_commander);
    if check_grant = 0 then
        exec_commander:='GRANT ' || role_name || ' TO ' || user_name;
        EXECUTE IMMEDIATE(exec_commander);
    else
        exec_commander:='GRANT ' || role_name || ' TO ' || user_name || ' WITH GRANT OPTION';
        EXECUTE IMMEDIATE(exec_commander);
    end if;
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
    EXECUTE IMMEDIATE(exec_commander);
commit;
end proc_user_role;

--exec proc_user_update('USER1', 'NHANVIEN', 'HOTEN',1);
--exec proc_user_insert('USER1', 'NHANVIEN', 1);
--exec proc_user_delete('USER1', 'NHANVIEN', 1);

--SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = 'USER1';

--var c refcursor;
--exec proc_user_table('USER1',:c)  
--print c;
