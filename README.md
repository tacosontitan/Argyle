# 🌈 Argyle

The argyle golfing language is an esoteric programming language based on [brainfuck](https://en.wikipedia.org/wiki/Brainfuck).

## Current ideas

- `>` increment the data pointer.
  - The default behavior is to increment by one.
  - Specifying a numeric value directly after this instruction will increment by that number.
- `<` decrement the data pointer by one.
  - The default behavior is to decrement by one.
  - Specifying a numeric value directly after this instruction will decrement by that number.
- `+` increment the data at the pointer by one.
  - The default behavior is to increment by one.
  - Specifying a numeric value directly after this instruction will increment by that number.
- `-` decrement the data at the pointer by one.
  - The default behavior is to decrement by one.
  - Specifying a numeric value directly after this instruction will decrement by that number.
- `[` jump to closing element if the data at the current pointer is zero.
- `]` jump to the opening element if the data at the current pointer is zero.
- `.` print the data at the current pointer.
- `,` accept a line of input and store it at the current pointer.
- `(` opens a capture group.
- `)` closes the current capture group.

## 🫙 Capture Group Issues

In brainfuck, you're working with one cell at a time which really simplifies storage, but over complicates access. In argyle, capture groups enable developers to store multiple cells worth of data at a time for concise code:

```argyle
(abc)_
```

The command above will store `abc` at the current pointer's position. However, what happens when the developer increments that cell?

```argyle
(abc)_+
```

What should the resulting value be? Mentally, the simplest way to increment this and have it feel natural, is to treat it like a number where it would just become `abd` by incrementing `c` by one.

### Logic

- `?` if.
- `:` else.
- `!` not.
- `^` xor.
- `&` and.
- `|` or.
- `~` nor.

## Hello World

In the brainfuck world, even hello world is a chore:

```brainfuck
++++++++[>++++[>++>+++>+++>+<<<<-]>+>+>->>+[<]<-]>>.>---.+++++++..+++.>>.<-.<.+++.------.--------.>>+.>++.
```

In argyle, since alphanumeric values can be captured as a group using `()`, we can simplify this to:

```argyle
(Hello, world!).
```

## 🛣️ Roadmap

Argyle is still in active development, and the following is our roadmap:

- [ ] Add support for `>`.
- [ ] Add support for `<`.
- [ ] Add support for numeric increment overrides.
- [ ] Add support for numeric decrement overrides.
- [ ] Add support for the jump forward `[` command.
- [ ] Add support for the jump backward `]` command.
- [ ] Add support for printing output.
- [ ] Add support for capturing input from users.
- [ ] Add support for raw capture groups.
- [ ] Add support for `async`/`await`.
