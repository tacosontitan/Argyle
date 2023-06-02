# 🌈 Argyle

The argyle golfing language is an esoteric programming language based on [brainfuck](https://en.wikipedia.org/wiki/Brainfuck#:~:text=The%20language%27s%20name%20is%20a,the%20boundaries%20of%20computer%20programming.). It currently offers the following features:

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
