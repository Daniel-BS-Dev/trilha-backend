# List, Lambda and Linq

## List
- Add() - adiciona
- Remove() - remove
- Count() - conta os items da lista
- Sort() - ordena numero

## Pegando a conta que não está null

- var contasNaoNulas = contas.Where(conta => conta.Numero); - Pegando a conta que não esta null

## Usando o OrderBy
- var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

## Usando o where e o orderBy
- var contasOrdenadas = contas.Where(conta => null).OrderBy(conta => conta.Numero); - Trazendo as contas não null e ordenada por numero
