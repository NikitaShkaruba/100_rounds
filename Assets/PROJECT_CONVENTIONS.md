# Project conventions

## Architecture

Scripts are divided into main 2 types:

- **Humble Objects**: Think of them as
  of `Models` in `Model-View-Controller`. They can be `MonoBehaviours` or simple classes. They contain separated logic
  that
  actors call,
  it
  improves code readability and extendability. They
  can't include life cycle functions (`Update`, `FixedUpdate`, `OnTriggerEnter2D`, `...`), but they can fill
  references to other scripts in the `Awake` life cycle function, it improves code flow and lowers down their
  responsibility.
- **Actors**: Think of them as
  of `Controllers` in `Model-View-Controller`. They can only be `MonoBehaviours`. They usually contain lots of humble
  objects in them which they order around. They may contain
  any life cycle
  functions (`Update`, `FixedUpdate`, `OnTriggerEnter2D`, `...`) from where they call humble object methods.

If you are fascinated about my `MVC` pattern usage, you should know that `Views` are unity game objects in the
hierarchy :)

There are also some misc types:

- **Shared** - Shared parts of code you need to reuse everywhere.
- **Service** - You can put some service dev scripts here.

## Naming

- If you are an actor, add `Actor` suffix.
- If you inherit `MonoBehaviour`, add `Behaviour` suffix. Actors are an exception.
