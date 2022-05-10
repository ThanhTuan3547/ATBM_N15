PROCEDURE  xem có the cap quyen select cho nguoi dùng có column level
CREATE OR REPLACE PROCEDURE proc_CreateViewUserSelectColumnLevel(
    ip_username nvarchar2,
    ip_column_name nvarchar2,
    ip_table_name nvarchar2,
    ip_granable nvarchar2
    )
IS
    user_name nvarchar2(200):=ip_username;
    column_name nvarchar2(200):=ip_column_name;
    table_name nvarchar2(200):=ip_table_name;
    exec_commander varchar(1000);
    priv nvarchar2(200);
    vw_name nvarchar2(200);
BEGIN 
    priv:='SELECT';
    exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE ';
    EXECUTE IMMEDIATE (exec_commander);
    
    IF UPPER(ip_granable) = 'TRUE' THEN

     exec_commander:='CREATE VIEW VW_USER_SELECT_COLUMN_LEVEL_'||ip_username||'_'||ip_column_name||'_'||ip_table_name
    || ' AS '|| 'SELECT ' ||column_name|| ' FROM '|| table_name;
    EXECUTE IMMEDIATE (exec_commander);
    
    
        vw_name:='VW_USER_SELECT_COLUMN_LEVEL_'||ip_username||'_'||ip_column_name||'_'||ip_table_name;
    exec_commander:='GRANT SELECT ON '||vw_name || ' TO ' ||ip_username|| ' WITH GRANT OPTION ';
        EXECUTE IMMEDIATE (exec_commander);
           
    ELSE 
     exec_commander:='CREATE VIEW VW_USER_SELECT_COLUMN_LEVEL_'||ip_username||'_'||ip_column_name||'_'||ip_table_name
    || ' AS '|| 'SELECT ' ||column_name|| ' FROM '|| table_name;
    EXECUTE IMMEDIATE (exec_commander);
    
      vw_name:='VW_USER_SELECT_COLUMN_LEVEL_'||ip_username||'_'||ip_column_name||'_'||ip_table_name;
    exec_commander:='GRANT SELECT ON '||vw_name || ' TO ' ||ip_username;
        EXECUTE IMMEDIATE (exec_commander);
    
    END IF;

    
   exec_commander:='ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE ';
    EXECUTE IMMEDIATE (exec_commander);
END proc_CreateViewUserSelectColumnLevel;
/
CREATE ROLE ROLE_DOCTOR IDENTIFIED BY ROLE_DOCTOR;
grant select on NHANVIEN to ROLE_DOCTOR;
grant update on NHANVIEN to ROLE_DOCTOR;
CREATE ROLE role_nghiencuu IDENTIFIED BY role_nghiencuu;
grant select on NHANVIEN to role_nghiencuu;
grant update on NHANVIEN to role_nghiencuu;
CREATE ROLE role_benhnhan IDENTIFIED BY role_benhnhan;
grant select on benhnhan to role_nghiencuu;
grant update on benhnhan to role_nghiencuu;