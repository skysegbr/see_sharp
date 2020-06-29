CREATE OR REPLACE PACKAGE LOJA_REGRAS IS

    --------------------------------------------------------------------
    -- lISTA TIPO PRESENTE
    --------------------------------------------------------------------
    PROCEDURE LISTAR_TIPO_PRESENTE (P_TIPO_PRODUTO OUT SYS_REFCURSOR);

    --------------------------------------------------------------------
    -- lISTA FORNCEDORES
    --------------------------------------------------------------------
    PROCEDURE LISTAR_FORN_PRESENTE (P_FORNECEDOR OUT SYS_REFCURSOR);

    --------------------------------------------------------------------
    -- lISTA MARCAS
    --------------------------------------------------------------------
    PROCEDURE LISTAR_MARCA_PRESENTE (P_MARCA OUT SYS_REFCURSOR);

    --------------------------------------------------------------------
    -- lISTA FINALIDADES
    --------------------------------------------------------------------
    PROCEDURE LISTAR_FINALIDADE_PRESENTE (P_FINALIDADE OUT SYS_REFCURSOR);

    --------------------------------------------------------------------
    -- RETORNA PRESENTE
    --------------------------------------------------------------------
    PROCEDURE RET_PRESENTE (P_COD_PRESENTE IN NUMBER DEFAULT 0,
                            P_PRESENTE     OUT SYS_REFCURSOR);

--------------------------------------------------------------------
-- REGISTRA PRESENTE
--------------------------------------------------------------------
PROCEDURE REGISTRA_PRESENTE (P_PRESENTE_DESC    IN TB_PRESENTE.PRESENTE_DESC%TYPE,
                             P_COD_TIPO         IN TB_PRESENTE.COD_TIPO%TYPE,
                             P_COD_MARCA        IN TB_PRESENTE.COD_MARCA%TYPE,
                             P_COD_FINALIDADE   IN TB_PRESENTE.COD_FINALIDADE%TYPE,
                             P_PRESENTE_COR     IN TB_PRESENTE.PRESENTE_COR%TYPE,
                             P_PRESENTE_TAMANHO IN TB_PRESENTE.PRESENTE_TAMANHO%TYPE,
                             P_PRESENTE_PRECO   IN TB_PRESENTE.PRESENTE_PRECO%TYPE,
                             P_COD_FORNECEDOR   IN TB_PRESENTE.COD_FORNECEDOR%TYPE);


END LOJA_REGRAS;
/
CREATE OR REPLACE PACKAGE BODY LOJA_REGRAS IS

--------------------------------------------------------------------
-- lISTA TIPO PRESENTE
--------------------------------------------------------------------
PROCEDURE LISTAR_TIPO_PRESENTE (P_TIPO_PRODUTO OUT SYS_REFCURSOR)IS
BEGIN
    OPEN P_TIPO_PRODUTO FOR
        SELECT PTI.COD_TIPO,
               PTI.DESC_TIPO
          FROM TB_PRESENTE_TIPO PTI;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO NA BUSCA DO TIPO DO PRESENTE ' || SQLERRM);
END LISTAR_TIPO_PRESENTE;

--------------------------------------------------------------------
-- lISTA FORNCEDORES
--------------------------------------------------------------------
PROCEDURE LISTAR_FORN_PRESENTE (P_FORNECEDOR OUT SYS_REFCURSOR)IS
BEGIN
    OPEN P_FORNECEDOR FOR
        SELECT PF.COD_FORNECEDOR,
               PF.NOME_FORNECEDOR
          FROM TB_PRESENTE_FORNECEDOR PF;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO NA BUSCA DO FORNECEDOR ' || SQLERRM);
END LISTAR_FORN_PRESENTE;

--------------------------------------------------------------------
-- lISTA MARCAS
--------------------------------------------------------------------
PROCEDURE LISTAR_MARCA_PRESENTE (P_MARCA OUT SYS_REFCURSOR)IS
BEGIN
    OPEN P_MARCA FOR
        SELECT PM.COD_MARCA,
               PM.MARCA_DESC
          FROM TB_PRESENTE_MARCA PM;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO NA BUSCA DAS MARCAS ' || SQLERRM);
END LISTAR_MARCA_PRESENTE;

--------------------------------------------------------------------
-- lISTA FINALIDADES
--------------------------------------------------------------------
PROCEDURE LISTAR_FINALIDADE_PRESENTE (P_FINALIDADE OUT SYS_REFCURSOR)IS
BEGIN
    OPEN P_FINALIDADE FOR
        SELECT PF.COD_FINALIDADE,
               PF.DESC_FINALIDADE,
               PF.FINALIDADE_ORIGEM
          FROM TB_PRESENTE_FINALIDADE PF;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO NA BUSCA DAS FINALIDADES ' || SQLERRM);
END LISTAR_FINALIDADE_PRESENTE;

--------------------------------------------------------------------
-- RETORNA PRESENTE
--------------------------------------------------------------------
PROCEDURE RET_PRESENTE (P_COD_PRESENTE IN NUMBER DEFAULT 0,
                        P_PRESENTE     OUT SYS_REFCURSOR)IS
BEGIN
    IF P_COD_PRESENTE <> 0 THEN
        OPEN P_PRESENTE FOR
            SELECT P.COD_PRESENTE,
                   P.PRESENTE_DESC,
                   PF.NOME_FORNECEDOR,
                   PM.MARCA_DESC,
                   PTI.DESC_TIPO,
                   PFI.DESC_FINALIDADE,
                   P.PRESENTE_PRECO
              FROM TB_PRESENTE_FINALIDADE PFI,
                   TB_PRESENTE_TIPO       PTI,
                   TB_PRESENTE_MARCA      PM,
                   TB_PRESENTE_FORNECEDOR PF,
                   TB_PRESENTE            P
             WHERE 1=1
               AND P.COD_PRESENTE = P_COD_PRESENTE
               AND PF.COD_FORNECEDOR = P.COD_FORNECEDOR
               AND PM.COD_MARCA = P.COD_MARCA
               AND PTI.COD_TIPO = P.COD_TIPO
               AND PFI.COD_FINALIDADE = P.COD_FINALIDADE;
    ELSE
        OPEN P_PRESENTE FOR
            SELECT P.COD_PRESENTE,
                   P.PRESENTE_DESC,
                   PM.MARCA_DESC,
                   P.PRESENTE_COR,
                   p.PRESENTE_TAMANHO,
                   P.PRESENTE_PRECO,
                   P.COD_TIPO
              FROM TB_PRESENTE_FINALIDADE PFI,
                   TB_PRESENTE_TIPO       PTI,
                   TB_PRESENTE_MARCA      PM,
                   TB_PRESENTE_FORNECEDOR PF,
                   TB_PRESENTE            P
             WHERE 1=1
               AND PF.COD_FORNECEDOR = P.COD_FORNECEDOR
               AND PM.COD_MARCA = P.COD_MARCA
               AND PTI.COD_TIPO = P.COD_TIPO
               AND PFI.COD_FINALIDADE = P.COD_FINALIDADE;
        
    END IF;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO NA BUSCA DO PRESENTE ' || SQLERRM);
END RET_PRESENTE;

--------------------------------------------------------------------
-- REGISTRA PRESENTE
--------------------------------------------------------------------
PROCEDURE REGISTRA_PRESENTE (P_PRESENTE_DESC    IN TB_PRESENTE.PRESENTE_DESC%TYPE,
                             P_COD_TIPO         IN TB_PRESENTE.COD_TIPO%TYPE,
                             P_COD_MARCA        IN TB_PRESENTE.COD_MARCA%TYPE,
                             P_COD_FINALIDADE   IN TB_PRESENTE.COD_FINALIDADE%TYPE,
                             P_PRESENTE_COR     IN TB_PRESENTE.PRESENTE_COR%TYPE,
                             P_PRESENTE_TAMANHO IN TB_PRESENTE.PRESENTE_TAMANHO%TYPE,
                             P_PRESENTE_PRECO   IN TB_PRESENTE.PRESENTE_PRECO%TYPE,
                             P_COD_FORNECEDOR   IN TB_PRESENTE.COD_FORNECEDOR%TYPE)IS
BEGIN
    
    DEBUG_UTIL(
        1, 
        'REGISTRA_PRESENTE',
        P_PRESENTE_DESC, 
        P_COD_TIPO,
        P_COD_MARCA,
        P_COD_FINALIDADE,
        P_PRESENTE_COR,
        P_PRESENTE_TAMANHO,
        P_PRESENTE_PRECO,
        P_COD_FORNECEDOR
    );
    INSERT INTO TB_PRESENTE(
        COD_PRESENTE,
        PRESENTE_DESC,
        COD_TIPO,
        COD_MARCA,
        COD_FINALIDADE,
        PRESENTE_COR,
        PRESENTE_TAMANHO,
        PRESENTE_PRECO,
        COD_FORNECEDOR
    )VALUES(
        SQ_PRESENTE.NEXTVAL,
        P_PRESENTE_DESC,
        P_COD_TIPO,
        P_COD_MARCA,
        P_COD_FINALIDADE,
        P_PRESENTE_COR,
        P_PRESENTE_TAMANHO,
        P_PRESENTE_PRECO,
        P_COD_FORNECEDOR
    );
    COMMIT;

EXCEPTION
    WHEN OTHERS THEN
        RAISE_APPLICATION_ERROR(-20001, 'OCORREU ALGUM ERRO AO INSERIR PRESENTE ' || SQLERRM);
END REGISTRA_PRESENTE;

END LOJA_REGRAS;
/
