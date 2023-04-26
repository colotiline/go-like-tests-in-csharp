run:
	dotnet clean -v q \
	&& \
	dotnet run \
	--project "./Colotiline.GoLikeTests/Colotiline.GoLikeTests.csproj" \
	-p:StartupObject=Colotiline.GoLikeTests.Program

test:
	dotnet clean -v q \
	&& \
	dotnet run \
	--project "./Colotiline.GoLikeTests/Colotiline.GoLikeTests.csproj" \
	-p:StartupObject=Colotiline.GoLikeTests.ProgramTests

publish:
	ETA=true dotnet publish -c Release -a x64