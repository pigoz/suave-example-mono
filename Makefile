FSI=fsharpi

dev:
	mono packages/FAKE/tools/FAKE.exe --fsiargs -d:MONO build.local.fsx

.PHONY: dev
