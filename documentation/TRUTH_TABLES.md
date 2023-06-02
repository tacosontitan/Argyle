# Truth Tables

Since maintaining support of logical operators is a part of maintaining a programming language, it's important to understand how those operators work. This document simply defines truth tables to help clarify how each logical operator should function. The following tables are defined in this document:

- [Not](#not)
- [And](#and)
- [Or](#or)
- [Xor](#xor)
- [Nor](#nor)
- [Nand](#nand)

## Not

The `not` operator is a unary operator, meaning it only takes one input. The following table defines the output of the `not` operator:

|  Input  |  Output  |
| :-----: | :------: |
| `false` | `true`   |
| `true`  | `false`  |

## And

The `and` operator is a binary operator, meaning it takes two inputs. The following table defines the output of the `and` operator:

| Input A | Input B | Output |
| :-----: | :-----: | :----: |
| `false` | `false` | `false` |
| `false` | `true`  | `false` |
| `true`  | `false` | `false` |
| `true`  | `true`  | `true`  |

## Or

The `or` operator is a binary operator, meaning it takes two inputs. The following table defines the output of the `or` operator:

| Input A | Input B | Output |
| :-----: | :-----: | :----: |
| `false` | `false` | `false` |
| `false` | `true`  | `true`  |
| `true`  | `false` | `true`  |
| `true`  | `true`  | `true`  |

## Xor

The `xor` operator is a binary operator, meaning it takes two inputs. The following table defines the output of the `xor` operator:

| Input A | Input B | Output |
| :-----: | :-----: | :----: |
| `false` | `false` | `false` |
| `false` | `true`  | `true`  |
| `true`  | `false` | `true`  |
| `true`  | `true`  | `false` |

## Nor

The `nor` operator is a binary operator, meaning it takes two inputs. The following table defines the output of the `nor` operator:

| Input A | Input B | Output |
| :-----: | :-----: | :----: |
| `false` | `false` | `true`  |
| `false` | `true`  | `false` |
| `true`  | `false` | `false` |
| `true`  | `true`  | `false` |

## Nand

The `nand` operator is a binary operator, meaning it takes two inputs. The following table defines the output of the `nand` operator:

| Input A | Input B | Output |
| :-----: | :-----: | :----: |
| `false` | `false` | `true`  |
| `false` | `true`  | `true`  |
| `true`  | `false` | `true`  |
| `true`  | `true`  | `false` |
